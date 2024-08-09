using System.Threading.Tasks;
using Grpc.Core;
using GrpcService.Domain;
using GrpcService.Protos;
using Microsoft.EntityFrameworkCore;
using User = GrpcService.Domain.User;
using Isopoh.Cryptography.Argon2;
using Microsoft.AspNetCore.Authorization;

namespace GrpcService.Services;

[Authorize]
public class UserService : Protos.UserService.UserServiceBase
{
    private readonly ApplicationDbContext _context;

    public UserService(ApplicationDbContext context)
    {
        _context = context;
    }

    public override async Task<UserResponse> CreateUser(CreateUserRequest request, ServerCallContext context)
    {
        
        var hashedPassword = Argon2.Hash(request.Password);
        
        var user = new User()
        {
            Name = request.Name,
            Email = request.Email,
            Password = hashedPassword
        };
        
        _context.Users.Add(user);
        await _context.SaveChangesAsync();
        return new UserResponse { User = new Protos.User { Id = user.Id, Name = user.Name, Email = user.Email, Password = user.Password } };
    }
    
    public override async Task<UserResponse> GetUser(GetUserRequest request, ServerCallContext context)
    {
        var user = await _context.Users.FindAsync(request.Id);
        if (user == null)
        {
            throw new RpcException(new Status(StatusCode.NotFound, "User not found"));
        }

        return new UserResponse { User = new Protos.User { Id = user.Id, Name = user.Name, Email = user.Email, Password = user.Password } };
    }

    public override async Task<UserResponse> UpdateUser(UpdateUserRequest request, ServerCallContext context)
    {
        var user = await _context.Users.FindAsync(request.Id);
        if (user == null)
        {
            throw new RpcException(new Status(StatusCode.NotFound, "User not found"));
        }

        user.Name = request.Name;
        user.Email = request.Email;
        user.Password = request.Password;

        _context.Users.Update(user);
        await _context.SaveChangesAsync();

        return new UserResponse { User = new Protos.User { Id = user.Id, Name = user.Name, Email = user.Email, Password = user.Password } };
    }

    public override async Task<DeleteUserResponse> DeleteUser(DeleteUserRequest request, ServerCallContext context)
    {
        var user = await _context.Users.FindAsync(request.Id);
        if (user == null)
        {
            throw new RpcException(new Status(StatusCode.NotFound, "User not found"));
        }

        _context.Users.Remove(user);
        await _context.SaveChangesAsync();

        return new DeleteUserResponse { Success = true };
    }

    public override async Task<ListUsersResponse> ListUsers(ListUsersRequest request, ServerCallContext context)
    {
        var users = await _context.Users.ToListAsync();

        var response = new ListUsersResponse();
        response.Users.AddRange(users.Select(u => new Protos.User { Id = u.Id, Name = u.Name, Email = u.Email, Password = u.Password }));

        return response;
    }
}