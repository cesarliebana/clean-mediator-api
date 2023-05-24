using SaaV.MediatR.Core.Domain.Responses;
using SaaV.MediatR.WebApi.Endpoints;
using SaaV.MediatR.WebApi.Models;

namespace SaaV.MediatR.WebApi.Extensions
{
    public static class WebApplicationExtensions
    {
        public static void MapDummyEndpoints(this WebApplication app)
        {
            RouteGroupBuilder builder = app.MapGroup("/dummies").WithDisplayName("Dummies").WithOpenApi();
            builder.MapGet("/", DummiesEndpoints.GetAllDummies)
                .WithName("GetAllDummies")
                .WithDescription("Gets all dummies")
                .Produces<GetAllDummiesResponse>(StatusCodes.Status200OK)
                .WithOpenApi();

            builder.MapGet("/{id}", DummiesEndpoints.GetDummyById)                
                .WithName("GetDummyById")
                .WithDescription("Gets a dummy with an id")
                .Produces<GetDummyResponse>(StatusCodes.Status200OK)
                .Produces(StatusCodes.Status404NotFound)
                .WithOpenApi();

            builder.MapPost("/", DummiesEndpoints.CreateDummy)
                .WithName("CreateDummy")
                .WithDescription("Creates a dummy")
                .Accepts<CreateDummyModel>("application/json")
                .Produces<GetDummyResponse>(StatusCodes.Status201Created)
                .WithOpenApi();

            builder.MapPut("/{id}", DummiesEndpoints.UpdateDummy)
                .WithName("UpdateDummy")
                .WithDescription("Updates a dummy")
                .Accepts<UpdateDummyModel>("application/json")
                .Produces<GetDummyResponse>(StatusCodes.Status200OK)
                .WithOpenApi();

            builder.MapDelete("/{id}", DummiesEndpoints.DeleteDummy)
                .WithName("DeleteDummy")
                .WithDescription("Deletes a dummy")
                .Produces(StatusCodes.Status204NoContent)
                .WithOpenApi();
        }
    }
}
