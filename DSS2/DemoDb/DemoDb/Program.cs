
using DemoDb.Data;
using Microsoft.EntityFrameworkCore;

namespace DemoDb
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseNpgsql("Server=localhost;Port=5432;Database=dss-posts;User Id=postgres;Password=0000;");
            });
             builder.Services.AddEndpointsApiExplorer();

            var app = builder.Build();


            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
