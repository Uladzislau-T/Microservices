using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PlatformService.Data;
using PlatformService.SyncDataServices.Http;

namespace PlatformService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }

    //public class Program
    //{
    //    public static void Main(string[] args)
    //    {
    //        var builder = WebApplication.CreateBuilder(args);

    //        // Add services to the container.
    //        builder.Services.AddDbContext<AppDbContext>(opt => 
    //            opt.UseInMemoryDatabase("InMem"));

    //        builder.Services.AddScoped<IPlatformRepository, PlatformRepository>();
    //        builder.Services.AddHttpClient<ICommandDataClient, HttpCommanDataClient>();

    //        builder.Services.AddControllers();

    //        builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

    //        builder.Services.AddEndpointsApiExplorer();
    //        builder.Services.AddSwaggerGen();

    //        Console.WriteLine($" --> CommandService Endpoint {builder.Configuration["CommandService"]}");

    //        Console.WriteLine("--> Using SqlServer Db");
    //        builder.Services.AddDbContext<AppDbContext>(opt =>
    //                opt.UseSqlServer(builder.Configuration.GetConnectionString("PlatformsConn")));

    //        var app = builder.Build();

    //        //if (app.Environment.IsProduction())
    //        //{



    //        //}
    //        //else
    //        //{
    //        //    app.UseSwagger();
    //        //    app.UseSwaggerUI();
    //        //}

    //        //app.UseAuthorization();

    //        app.MapControllers();

    //        //PrepDb.PrepPopulation(app, app.Environment.IsProduction());            

    //        app.Run();
    //    }
    //}
}