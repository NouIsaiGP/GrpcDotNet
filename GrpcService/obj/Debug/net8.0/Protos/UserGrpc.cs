// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/user.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981, 0612
#region Designer generated code

using grpc = global::Grpc.Core;

namespace GrpcService.Protos {
  public static partial class UserService
  {
    static readonly string __ServiceName = "UserService";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcService.Protos.CreateUserRequest> __Marshaller_CreateUserRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcService.Protos.CreateUserRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcService.Protos.UserResponse> __Marshaller_UserResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcService.Protos.UserResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcService.Protos.GetUserRequest> __Marshaller_GetUserRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcService.Protos.GetUserRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcService.Protos.UpdateUserRequest> __Marshaller_UpdateUserRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcService.Protos.UpdateUserRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcService.Protos.DeleteUserRequest> __Marshaller_DeleteUserRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcService.Protos.DeleteUserRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcService.Protos.DeleteUserResponse> __Marshaller_DeleteUserResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcService.Protos.DeleteUserResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcService.Protos.ListUsersRequest> __Marshaller_ListUsersRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcService.Protos.ListUsersRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcService.Protos.ListUsersResponse> __Marshaller_ListUsersResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcService.Protos.ListUsersResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::GrpcService.Protos.CreateUserRequest, global::GrpcService.Protos.UserResponse> __Method_CreateUser = new grpc::Method<global::GrpcService.Protos.CreateUserRequest, global::GrpcService.Protos.UserResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateUser",
        __Marshaller_CreateUserRequest,
        __Marshaller_UserResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::GrpcService.Protos.GetUserRequest, global::GrpcService.Protos.UserResponse> __Method_GetUser = new grpc::Method<global::GrpcService.Protos.GetUserRequest, global::GrpcService.Protos.UserResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetUser",
        __Marshaller_GetUserRequest,
        __Marshaller_UserResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::GrpcService.Protos.UpdateUserRequest, global::GrpcService.Protos.UserResponse> __Method_UpdateUser = new grpc::Method<global::GrpcService.Protos.UpdateUserRequest, global::GrpcService.Protos.UserResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateUser",
        __Marshaller_UpdateUserRequest,
        __Marshaller_UserResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::GrpcService.Protos.DeleteUserRequest, global::GrpcService.Protos.DeleteUserResponse> __Method_DeleteUser = new grpc::Method<global::GrpcService.Protos.DeleteUserRequest, global::GrpcService.Protos.DeleteUserResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteUser",
        __Marshaller_DeleteUserRequest,
        __Marshaller_DeleteUserResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::GrpcService.Protos.ListUsersRequest, global::GrpcService.Protos.ListUsersResponse> __Method_ListUsers = new grpc::Method<global::GrpcService.Protos.ListUsersRequest, global::GrpcService.Protos.ListUsersResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListUsers",
        __Marshaller_ListUsersRequest,
        __Marshaller_ListUsersResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GrpcService.Protos.UserReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of UserService</summary>
    [grpc::BindServiceMethod(typeof(UserService), "BindService")]
    public abstract partial class UserServiceBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::GrpcService.Protos.UserResponse> CreateUser(global::GrpcService.Protos.CreateUserRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::GrpcService.Protos.UserResponse> GetUser(global::GrpcService.Protos.GetUserRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::GrpcService.Protos.UserResponse> UpdateUser(global::GrpcService.Protos.UpdateUserRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::GrpcService.Protos.DeleteUserResponse> DeleteUser(global::GrpcService.Protos.DeleteUserRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::GrpcService.Protos.ListUsersResponse> ListUsers(global::GrpcService.Protos.ListUsersRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(UserServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_CreateUser, serviceImpl.CreateUser)
          .AddMethod(__Method_GetUser, serviceImpl.GetUser)
          .AddMethod(__Method_UpdateUser, serviceImpl.UpdateUser)
          .AddMethod(__Method_DeleteUser, serviceImpl.DeleteUser)
          .AddMethod(__Method_ListUsers, serviceImpl.ListUsers).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, UserServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_CreateUser, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcService.Protos.CreateUserRequest, global::GrpcService.Protos.UserResponse>(serviceImpl.CreateUser));
      serviceBinder.AddMethod(__Method_GetUser, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcService.Protos.GetUserRequest, global::GrpcService.Protos.UserResponse>(serviceImpl.GetUser));
      serviceBinder.AddMethod(__Method_UpdateUser, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcService.Protos.UpdateUserRequest, global::GrpcService.Protos.UserResponse>(serviceImpl.UpdateUser));
      serviceBinder.AddMethod(__Method_DeleteUser, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcService.Protos.DeleteUserRequest, global::GrpcService.Protos.DeleteUserResponse>(serviceImpl.DeleteUser));
      serviceBinder.AddMethod(__Method_ListUsers, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcService.Protos.ListUsersRequest, global::GrpcService.Protos.ListUsersResponse>(serviceImpl.ListUsers));
    }

  }
}
#endregion
