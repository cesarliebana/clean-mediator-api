using MediatR;
using SaaV.MediatR.Core.Domain.Requests;
using SaaV.MediatR.Core.Domain.Responses;
using SaaV.MediatR.Core.Shared.Exceptions;

namespace SaaV.MediatR.Core.Domain.Handlers
{
    public class UpdateDummyHandler : IRequestHandler<UpdateDummyRequest, GetDummyResponse>
    {
        public Task<GetDummyResponse> Handle(UpdateDummyRequest updateDummyRequest, CancellationToken cancellationToken)
        {
            if (updateDummyRequest.Id <= 0) throw new DummyNotFoundException(updateDummyRequest.Id);

            return Task.FromResult( new GetDummyResponse(updateDummyRequest.Id, updateDummyRequest.Name, DateTime.UtcNow));
        }
    }
}
