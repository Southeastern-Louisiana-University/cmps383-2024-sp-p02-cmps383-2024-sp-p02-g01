using Microsoft.AspNetCore.Identity;

namespace Selu383.SP24.Api.Features.Hotels
{
    public class User : IdentityUser<int>
    {
        //public override int Id { get; set; }
        public ICollection<UserRole>? Roles { get; set; }
    }
}