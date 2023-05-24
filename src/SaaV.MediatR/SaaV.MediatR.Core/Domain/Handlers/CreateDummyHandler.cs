using MediatR;
using SaaV.MediatR.Core.Domain.Requests;
using SaaV.MediatR.Core.Domain.Responses;

namespace SaaV.MediatR.Core.Domain.Handlers
{
    public class CreateDummyHandler : IRequestHandler<CreateDummyRequest, GetDummyResponse>
    {

        public Task<GetDummyResponse> Handle(CreateDummyRequest createDummyRequest, CancellationToken cancellationToken)
        {
            return Task.FromResult(new GetDummyResponse(Random.Shared.Next(), createDummyRequest.Name, DateTime.UtcNow));
        }
    }
}
