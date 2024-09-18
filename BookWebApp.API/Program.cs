
using BookWebApp.Core.Interfaces.InfrastructureInterfaces.UnitOfWork;
using BookWebApp.Infrastructure;
using BookWebApp.Infrastructure.Repositories.UnitOfWork;
using BookWebApp.Presentation.GraphQL.GraphQLMutations;
using BookWebApp.Presentation.GraphQL.GraphQLQueries;
using Microsoft.EntityFrameworkCore;

namespace BookWebApp.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContextFactory<ApplicationContext>(opt =>
            {
                opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConn"), b => b.MigrationsAssembly("BookWebApp.Infrastructure"));
            });

            builder.Services.AddMediatR(opt => opt.RegisterServicesFromAssembly(typeof(Application.Startup).Assembly));

            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

            builder.Services.AddGraphQLServer()
                .AddQueryType<Query>()
                .AddMutationType<Mutation>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapGraphQL();

            app.MapControllers();

            app.Run();
        }
    }
}