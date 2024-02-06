using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;

namespace Selu383.SP24.Api.Features.Hotels
{
    public class UserRole : IdentityUserRole<int>
    {
        public User? User { get; set; }
        public Role? Role { get; set; }
    }
}
