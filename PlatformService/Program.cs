using Microsoft.EntityFrameworkCore;
using PlatformService.Data;
using PlatformService.SyncDataServices.Http;

namespace PlatformService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddDbContext<AppDbContext>(opt => 
                opt.UseInMemoryDatabase("InMem"));

            builder.Services.AddScoped<IPlatformRepository, PlatformRepository>();
            builder.Services.AddHttpClient<ICommandDataClient, HttpCommanDataClient>();

            builder.Services.AddControllers();

            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();

            app.MapControllers();

            PrepDb.PrepPopulation(app);

            Console.WriteLine($" --> CommandService Endpoint {builder.Configuration["CommandService"]}");

            app.Run();
        }
    }
}