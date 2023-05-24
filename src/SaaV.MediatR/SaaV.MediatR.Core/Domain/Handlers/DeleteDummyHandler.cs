using MediatR;
using SaaV.MediatR.Core.Domain.Requests;
using SaaV.MediatR.Core.Shared.Exceptions;

namespace SaaV.MediatR.Core.Domain.Handlers
{
    public class DeleteDummyHandler : IRequestHandler<DeleteDummyRequest>
    {
        public Task Handle(DeleteDummyRequest deleteDummyRequest, CancellationToken cancellationToken)
        {
            if (deleteDummyRequest.Id <= 0) throw new DummyNotFoundException(deleteDummyRequest.Id);
            
            return Task.CompletedTask;
        }
    }
}
