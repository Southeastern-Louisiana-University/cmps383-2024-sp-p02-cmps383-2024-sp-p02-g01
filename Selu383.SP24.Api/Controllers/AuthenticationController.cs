using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Selu383.SP24.Api.Features.Hotels;

namespace Selu383.SP24.Api.Controllers
{
    [ApiController]
    [Route("api/authentication")]
    public class AuthenticationController
    {
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;

        public AuthenticationController(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }
    }
}
