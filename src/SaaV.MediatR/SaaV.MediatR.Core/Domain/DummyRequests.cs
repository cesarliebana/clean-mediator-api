using MediatR;
using SaaV.MediatR.Core.Domain.Responses;

namespace SaaV.MediatR.Core.Domain.Requests
{
    public record struct CreateDummyRequest(string Name) : IRequest<GetDummyResponse>;
    
    public record struct DeleteDummyRequest(int Id) : IRequest;

    public record struct GetAllDummiesRequest : IRequest<GetAllDummiesResponse>;

    public record struct GetDummyByIdRequest(int Id) : IRequest<GetDummyResponse>;

    public record struct UpdateDummyRequest(int Id, string Name) : IRequest<GetDummyResponse>;
}
