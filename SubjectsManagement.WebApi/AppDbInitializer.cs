using SubjectsManagement.Persistence;
using Microsoft.EntityFrameworkCore;

namespace SubjectsManagement.WebApi
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                if (context != null)
                {
                    context.Database.Migrate();
                }
            }
        }
    }
}
