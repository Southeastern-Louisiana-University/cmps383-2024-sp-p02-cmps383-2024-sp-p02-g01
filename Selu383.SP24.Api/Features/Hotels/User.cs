using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Selu383.SP24.Api.Features.Hotels
{
    public class User : IdentityUser<int>
    {
        //public override int Id { get; set; }
        public ICollection<UserRole>? Roles { get; set; }
    }

    public class UserDto
    {
        public int Id { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string[] Roles { get; set; } = Array.Empty<string>();
    }

    public class CreateUserDto
    {
        [Required] public string UserName { get; set; } = string.Empty;

        [Required] public string Password { get; set; } = string.Empty;

        [Required] public string[] Roles { get; set; } = Array.Empty<string>();
    }
}