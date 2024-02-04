namespace Selu383.SP24.Api.Features.Hotels
{
    public class Role
    {
        public int Id { get; set; }
        public ICollection<UserRole>? Roles { get; set; }
    }
}
