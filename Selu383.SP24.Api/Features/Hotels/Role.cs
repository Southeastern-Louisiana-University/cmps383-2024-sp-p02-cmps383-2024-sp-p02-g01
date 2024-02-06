using Microsoft.AspNetCore.Identity;

namespace Selu383.SP24.Api.Features.Hotels
{
    public class Role : IdentityRole<int>
    {
        //public override int Id { get; set; }
        public ICollection<UserRole>? Users { get; set; }
    }
}
