using MediatR;
using SaaV.MediatR.Core.Domain.Requests;
using SaaV.MediatR.Core.Domain.Responses;
using SaaV.MediatR.Core.Shared.Exceptions;

namespace SaaV.MediatR.Core.Domain.Handlers
{
    public class GetDummyByIdHandler : IRequestHandler<GetDummyByIdRequest, GetDummyResponse>
    {
        public Task<GetDummyResponse> Handle(GetDummyByIdRequest getDummyRequest, CancellationToken cancellationToken)
        {
            if (getDummyRequest.Id <= 0) throw new DummyNotFoundException(getDummyRequest.Id);
            
            return Task.FromResult(new GetDummyResponse(getDummyRequest.Id, $"Dummy-{getDummyRequest.Id}", DateTime.UtcNow));
        }
    }
}
