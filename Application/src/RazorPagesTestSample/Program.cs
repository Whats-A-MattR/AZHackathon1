using System;
using System.Linq;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using RazorPagesTestSample.Data;

// comment
// another comment
// yet another comment
// please work now
// okay this should do it

// docker push now?
// docker work now pelase

// please 
// please


// deploy to the site now thanks
// proper attribution matters

//now?
// wrong thing bro
// this looks better

// feature 1 branch
// feature 1 branch v2

namespace RazorPagesTestSample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();

            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var db = services.GetRequiredService<AppDbContext>();

                db.Database.EnsureCreated();

                if (!db.Messages.Any())
                {
                    try
                    {
                        db.Initialize();
                    }
                    catch (Exception ex)
                    {
                        var logger = services.GetRequiredService<ILogger<Program>>();
                        logger.LogError(ex, "An error occurred seeding the database. Error: {Message}", ex.Message);
                    }
                }
            }

            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
