using Microsoft.Extensions.DependencyInjection;
using SaaV.MediatR.Core.Domain.Handlers;
using SaaV.MediatR.WebApi.Extensions;
using SaaV.MediatR.WebApi.Middlewares;

namespace SaaV.MediatR.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddAuthorization();

            builder.Services.AddMediatR(configuration => configuration.RegisterServicesFromAssembly(typeof(CreateDummyHandler).Assembly));

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapDummyEndpoints();

            app.UseMiddleware<ExceptionMiddleware>();

            app.Run();
        }
    }
}