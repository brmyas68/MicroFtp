// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ftp.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981
#region Designer generated code

using grpc = global::Grpc.Core;

namespace ProtoFtp {
  public static partial class FTPService
  {
    static readonly string __ServiceName = "ProtoFtp.FTPService";

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
    static readonly grpc::Marshaller<global::ProtoFtp.RequestFile> __Marshaller_ProtoFtp_RequestFile = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ProtoFtp.RequestFile.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::ProtoFtp.ResponseFile> __Marshaller_ProtoFtp_ResponseFile = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ProtoFtp.ResponseFile.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::ProtoFtp.RequestInsertFtp> __Marshaller_ProtoFtp_RequestInsertFtp = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ProtoFtp.RequestInsertFtp.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::ProtoFtp.ResponseInsertFtp> __Marshaller_ProtoFtp_ResponseInsertFtp = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ProtoFtp.ResponseInsertFtp.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::ProtoFtp.RequestGetAllFtp> __Marshaller_ProtoFtp_RequestGetAllFtp = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ProtoFtp.RequestGetAllFtp.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::ProtoFtp.ResponseGetAllFtp> __Marshaller_ProtoFtp_ResponseGetAllFtp = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ProtoFtp.ResponseGetAllFtp.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::ProtoFtp.RequestFile, global::ProtoFtp.ResponseFile> __Method_UploadFile = new grpc::Method<global::ProtoFtp.RequestFile, global::ProtoFtp.ResponseFile>(
        grpc::MethodType.ClientStreaming,
        __ServiceName,
        "UploadFile",
        __Marshaller_ProtoFtp_RequestFile,
        __Marshaller_ProtoFtp_ResponseFile);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::ProtoFtp.RequestInsertFtp, global::ProtoFtp.ResponseInsertFtp> __Method_Insert = new grpc::Method<global::ProtoFtp.RequestInsertFtp, global::ProtoFtp.ResponseInsertFtp>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Insert",
        __Marshaller_ProtoFtp_RequestInsertFtp,
        __Marshaller_ProtoFtp_ResponseInsertFtp);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::ProtoFtp.RequestGetAllFtp, global::ProtoFtp.ResponseGetAllFtp> __Method_GetAll = new grpc::Method<global::ProtoFtp.RequestGetAllFtp, global::ProtoFtp.ResponseGetAllFtp>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetAll",
        __Marshaller_ProtoFtp_RequestGetAllFtp,
        __Marshaller_ProtoFtp_ResponseGetAllFtp);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::ProtoFtp.FtpReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of FTPService</summary>
    [grpc::BindServiceMethod(typeof(FTPService), "BindService")]
    public abstract partial class FTPServiceBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::ProtoFtp.ResponseFile> UploadFile(grpc::IAsyncStreamReader<global::ProtoFtp.RequestFile> requestStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::ProtoFtp.ResponseInsertFtp> Insert(global::ProtoFtp.RequestInsertFtp request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::ProtoFtp.ResponseGetAllFtp> GetAll(global::ProtoFtp.RequestGetAllFtp request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for FTPService</summary>
    public partial class FTPServiceClient : grpc::ClientBase<FTPServiceClient>
    {
      /// <summary>Creates a new client for FTPService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public FTPServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for FTPService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public FTPServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected FTPServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected FTPServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncClientStreamingCall<global::ProtoFtp.RequestFile, global::ProtoFtp.ResponseFile> UploadFile(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UploadFile(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncClientStreamingCall<global::ProtoFtp.RequestFile, global::ProtoFtp.ResponseFile> UploadFile(grpc::CallOptions options)
      {
        return CallInvoker.AsyncClientStreamingCall(__Method_UploadFile, null, options);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::ProtoFtp.ResponseInsertFtp Insert(global::ProtoFtp.RequestInsertFtp request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Insert(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::ProtoFtp.ResponseInsertFtp Insert(global::ProtoFtp.RequestInsertFtp request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Insert, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::ProtoFtp.ResponseInsertFtp> InsertAsync(global::ProtoFtp.RequestInsertFtp request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return InsertAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::ProtoFtp.ResponseInsertFtp> InsertAsync(global::ProtoFtp.RequestInsertFtp request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Insert, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::ProtoFtp.ResponseGetAllFtp GetAll(global::ProtoFtp.RequestGetAllFtp request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAll(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::ProtoFtp.ResponseGetAllFtp GetAll(global::ProtoFtp.RequestGetAllFtp request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetAll, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::ProtoFtp.ResponseGetAllFtp> GetAllAsync(global::ProtoFtp.RequestGetAllFtp request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAllAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::ProtoFtp.ResponseGetAllFtp> GetAllAsync(global::ProtoFtp.RequestGetAllFtp request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetAll, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override FTPServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new FTPServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(FTPServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_UploadFile, serviceImpl.UploadFile)
          .AddMethod(__Method_Insert, serviceImpl.Insert)
          .AddMethod(__Method_GetAll, serviceImpl.GetAll).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, FTPServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_UploadFile, serviceImpl == null ? null : new grpc::ClientStreamingServerMethod<global::ProtoFtp.RequestFile, global::ProtoFtp.ResponseFile>(serviceImpl.UploadFile));
      serviceBinder.AddMethod(__Method_Insert, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::ProtoFtp.RequestInsertFtp, global::ProtoFtp.ResponseInsertFtp>(serviceImpl.Insert));
      serviceBinder.AddMethod(__Method_GetAll, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::ProtoFtp.RequestGetAllFtp, global::ProtoFtp.ResponseGetAllFtp>(serviceImpl.GetAll));
    }

  }
}
#endregion
