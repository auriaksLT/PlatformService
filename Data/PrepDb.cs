using System;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using PlatformService.Models;

namespace PlatformService.Data
{
    // Static class cannot get constructor dependency injection
    public static class PrepDb
    {
        // To work, we need app instance "IApplicationBuilder app" with its LIB -> .Builder
        // Then add to startup.cs to activate it in a pipeline

        // Why using scope?

        // Public Method (will setup database context)
        public static void PrepPopulation(IApplicationBuilder app)
        {
            using( var serviceScope = app.ApplicationServices.CreateScope())
            {
                SeedData(serviceScope.ServiceProvider.GetService<AppDbContext>());
            }
        }

         private static void SeedData(AppDbContext context)
        {
            // Check if there is any data, related to the platforms in the DB
            if(!context.Platforms.Any())
            {
                Console.WriteLine(" --> Seeding Data ...");

                // Add to context Database
                context.Platforms.AddRange(
                    new Platform(){ Name = "Dot Net", Publisher = "Microsoft", Cost="Free" },
                    new Platform(){ Name = "SQL Server Express", Publisher = "Microsoft", Cost="Free" },
                    new Platform(){ Name = "Kubernetes", Publisher = "CNC Computing", Cost="Free" }
                );

                context.SaveChanges();
            }
            else
            {
                Console.WriteLine(" --> We already have Data");
            }
        }
    }
}