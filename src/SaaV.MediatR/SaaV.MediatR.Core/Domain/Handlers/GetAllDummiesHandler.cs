using MediatR;
using SaaV.MediatR.Core.Domain.Requests;
using SaaV.MediatR.Core.Domain.Responses;

namespace SaaV.MediatR.Core.Domain.Handlers
{
    public class GetAllDummiesHandler : IRequestHandler<GetAllDummiesRequest, GetAllDummiesResponse>
    {
        public Task<GetAllDummiesResponse> Handle(GetAllDummiesRequest getAllDummiesRequest, CancellationToken cancellationToken)
        {
            List<DummyListItem> dummies = new()
            {
                new DummyListItem(1, "Dummy-01"),
                new DummyListItem(2, "Dummy-02"),
                new DummyListItem(3, "Dummy-03")
            };

            return Task.FromResult(new GetAllDummiesResponse(dummies));
        }
    }
}
