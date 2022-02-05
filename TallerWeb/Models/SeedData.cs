using Microsoft.EntityFrameworkCore;
using TallerWeb.Data;

namespace TallerWeb.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new TallerWebContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<TallerWebContext>>()))
            {
                // Look for any movies.
                if (context.Users.Any())
                {
                    return;   // DB has been seeded
                }

               
                context.SaveChanges();
            }
        }
    }
}

