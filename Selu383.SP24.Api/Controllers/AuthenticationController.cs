using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Selu383.SP24.Api.Data;
using Selu383.SP24.Api.Features.Hotels;
using System.Runtime.CompilerServices;
using System.Security.Claims;

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

        [HttpGet("me")]
        [Authorize]
        public async Task<ActionResult<UserDto>> Me(User user)
        {
            var username = GetCurrentUserName(user);

            if (string.IsNullOrEmpty(username))
            {
                return Unauthorized();
            }

            var resultDto = await GetUserDto(userManager.Users).SingleAsync
                (x => x.UserName == username);

            return Ok(resultDto);
        }

        private string? GetCurrentUserName(ClaimsPrincipal claimsPrincipal)
        {
            return claimsPrincipal.Identity?.Name;
        }
    }
}
