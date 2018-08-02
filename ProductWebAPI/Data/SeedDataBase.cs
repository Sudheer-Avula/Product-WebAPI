using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductWebAPI.Data
{
    public class SeedDataBase
    {
        public static void Initilize(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetRequiredService<ApplicationDbContext>();
            var userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            context.Database.EnsureCreated();

            if(!context.Users.Any())
            {
                ApplicationUser user = new ApplicationUser()
                {
                    Email = "sudheer@live.in",
                    SecurityStamp = Guid.NewGuid().ToString(),
                    UserName = "Sudheer.Avula"
                };

                var result = userManager.CreateAsync(user, "Password@123");
                
            }

        }
    }
}
