using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MebelShop.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;

namespace MebelShop.data
{
    public class DbInitializor
    {
        public async static Task Seed(
            MebelContext context,
           RoleManager< IdentityRole> roleManager,
           UserManager<ApplicationUser> userManager,
             IConfiguration configuration   )
        {

            await context.Database.EnsureCreatedAsync();
            if(!await roleManager.RoleExistsAsync(SD.AdminRole))
            {
              await  roleManager.CreateAsync(new IdentityRole(SD.AdminRole));
            }
            if(! await roleManager.RoleExistsAsync(SD.UserRole))
            {
                await roleManager.CreateAsync(new IdentityRole(SD.UserRole));
            }
            if ( await userManager.FindByEmailAsync("gasimvm@code.edu.az") == null)
            {
                var admin = new ApplicationUser()
                {
                    Email = "gasimvm@code.edu.az",
                    UserName = "gasimvm@code.edu.az",
                    Lastname = "Mammadov",
                    FirstName="Qasim"
                };
              var result=await  userManager.CreateAsync(admin, configuration["AdminSetting:Password"]);
                if (result.Succeeded)
                {
                  await  userManager.AddToRoleAsync(admin,SD.AdminRole);
                }
            }
        }
    }
}
