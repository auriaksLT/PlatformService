using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

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
            
        }
    }
}