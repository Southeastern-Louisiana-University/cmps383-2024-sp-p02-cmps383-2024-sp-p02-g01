namespace Selu383.SP24.Api.Features.Hotels
{
    public class User
    {
        public int Id { get; set; }
        public ICollection<UserRole>? Roles { get; set; }
    }
}