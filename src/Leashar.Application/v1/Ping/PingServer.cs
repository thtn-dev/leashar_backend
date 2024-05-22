using MediatR;
namespace Leashar.Application.v1.Ping
{
    public class PingServerCommand : IRequest<string>
    {
        public PingServerCommand() { }
    }

    public class PingServerCommandHandler : IRequestHandler<PingServerCommand, string>
    {
        public const string Pong = "Pong";
        public Task<string> Handle(PingServerCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(Pong);
        }
    }
}
