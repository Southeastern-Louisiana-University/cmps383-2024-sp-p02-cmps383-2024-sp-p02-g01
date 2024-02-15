using Microsoft.AspNetCore.Identity;
using Selu383.SP24.Api.Features.Hotels;

namespace Selu383.SP24.Api.Data
{
    public class SeedHelper
    {
        private static async Task AddUsers(IServiceProvider serviceProvider)
        {
            const string defaultPass = "Password123!";
            var userManager = serviceProvider.GetRequiredService<UserManager<User>>();

            if (userManager.Users.Any())
            {
                return;
            }

            var adminUser = new User
            {
                UserName = "galkadi",
            };

            var result = await userManager.CreateAsync(adminUser, defaultPass);
            if (result.Succeeded)
            {
                await userManager.AddToRoleAsync(adminUser, RoleNames.Admin);
            }
            var bob = new User
            {
                UserName = "bob",
            };

            await userManager.CreateAsync(bob, defaultPass);
            await userManager.AddToRoleAsync(bob, RoleNames.User);

            var sue = new User
            {
                UserName = "sue",
            };

            await userManager.CreateAsync(sue, defaultPass);
            await userManager.AddToRoleAsync(sue, RoleNames.User);

        }
    }
}
