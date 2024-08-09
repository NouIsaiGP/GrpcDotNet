using Grpc.Core;
using GrpcService.Protos;
using Isopoh.Cryptography.Argon2;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using RegisterRequest = GrpcService.Protos.RegisterRequest;
using User = GrpcService.Domain.User;

namespace GrpcService.Services;

public class AuthService : Protos.AuthService.AuthServiceBase
{
     private readonly ApplicationDbContext _context;

        public AuthService(ApplicationDbContext context)
        {
            _context = context;
        }

        public override async Task<RegisterResponse> Register(RegisterRequest request, ServerCallContext context)
        {
            if (_context.Users.Any(u => u.Email == request.Email.ToLower()))
            {
                throw new RpcException(new Status(StatusCode.AlreadyExists, "User already exists"));
            }

            var hashedPassword = Argon2.Hash(request.Password);

            var user = new User()
            {
                Name = request.Name,
                Email = request.Email.ToLower(),
                Password = hashedPassword  
            };

            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            // Generar el token JWT
            var token = GenerateJwtToken(user);

            return new RegisterResponse
            {
                Success = true,
                Token = token
            };
        }

        public override Task<GenerateTokenResponse> GenerateToken(GenerateTokenRequest request, ServerCallContext context)
        {
            var user = _context.Users.SingleOrDefault(u => u.Name == request.Username || u.Email == request.Username);

            if (user == null || !Argon2.Verify(user.Password, request.Password))
            {
                throw new RpcException(new Status(StatusCode.Unauthenticated, "Invalid credentials"));
            }

            // Generar el token JWT
            var token = GenerateJwtToken(user);

            return Task.FromResult(new GenerateTokenResponse { Token = token });
        }

        private string GenerateJwtToken(User user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(Environment.GetEnvironmentVariable("JWT_SECRET"));

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                    new Claim(ClaimTypes.Name, user.Name),
                    new Claim(ClaimTypes.Email, user.Email)
                }),
                Expires = DateTime.UtcNow.AddHours(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
}