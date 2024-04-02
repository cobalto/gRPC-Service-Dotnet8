using Google.Protobuf.WellKnownTypes;
using Grpc.Core;

namespace GrpcDemoService.Services
{
    /// <summary>
    /// Represents a service that greets clients.
    /// </summary>
    public class GreeterService : Greeter.GreeterBase
    {
        private readonly ILogger<GreeterService> _logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="GreeterService"/> class.
        /// </summary>
        /// <param name="logger"></param>
        public GreeterService(ILogger<GreeterService> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Greets the client with a hello message.
        /// </summary>
        /// <param name="request">The request containing the GET request.</param>
        /// <param name="context">The context for the server-side call.</param>
        /// <returns>A task representing the asynchronous operation. The task result contains the hello reply.</returns>
        public override Task<HelloReply> SayHelloOnlyName(HelloOnlyNameRequest request, ServerCallContext context)
        {
            return Task.FromResult(new HelloReply
            {
                Message = $"Hello {request.Name}",
                Timestamp = Timestamp.FromDateTime(DateTime.UtcNow),
            });
        }

        /// <summary>
        /// Greets the client with a hello message.
        /// </summary>
        /// <param name="request">The request containing the POST request</param>
        /// <param name="context">The context for the server-side call.</param>
        /// <returns>A task representing the asynchronous operation. The task result contains the hello reply.</returns>
        public override Task<HelloReply> SayHelloFullName(HelloFullNameRequest request, ServerCallContext context)
        {
            if(request.Surname is null or "")
            {
                throw new RpcException(new Status(StatusCode.InvalidArgument, "You forgot your surname, honey?"));
            }

            return Task.FromResult(new HelloReply
            {
                Message = $"Hello {request.Name} {request.Surname}",
                Timestamp = Timestamp.FromDateTime(DateTime.UtcNow),
            });
        }
    }
}
