using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace PlayMinecraftBingo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();

            app.MapGet("/fetchr-seed-viewer/random", () => Results.Redirect("/fetchr-seed-viewer/" + FetchrSeeds.Random()));
            app.MapGet("/fetchr-seed-picking-helper/random", () => Results.Redirect("/fetchr-seed-picking-helper/" + FetchrSeeds.Random()));

            app.Run();
        }
    }
}
