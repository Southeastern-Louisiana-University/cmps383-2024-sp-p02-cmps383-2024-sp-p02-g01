using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Selu383.SP24.Api.Features.Hotels;

namespace Selu383.SP24.Api.Data;

//Test push

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    public DataContext()
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        var userRoleBuilder = modelBuilder.Entity<UserRole>();

        userRoleBuilder.HasKey(x => new { x.UserId, x.RoleId });

        userRoleBuilder.HasOne(navigationExpression: x => x.Role)
            .WithMany(navigationExpression: x => x.Users)
            .HasForeignKey(x => x.RoleId);

        userRoleBuilder.HasOne(navigationExpression: x => x.User)
            .WithMany(navigationExpression: x => x.Roles)
            .HasForeignKey(x => x.UserId);


        modelBuilder.ApplyConfigurationsFromAssembly(typeof(DataContext).Assembly);
    }

    public virtual ICollection<IdentityUserRole<int>> Roles { get; } = new List<IdentityUserRole<int>>();
    public virtual ICollection<IdentityUserRole<int>> Users { get; } = new List<IdentityUserRole<int>>();
    public virtual ICollection<IdentityRole<int>> Role { get; } = new List<IdentityRole<int>>();
    public virtual ICollection<IdentityUser<int>> User { get; } = new List<IdentityUser<int>>();
    public virtual ICollection<IdentityUserLogin<int>> Logins { get; } = new List<IdentityUserLogin<int>>();
    public virtual ICollection<IdentityRoleClaim<int>> Claims { get; } = new List<IdentityRoleClaim<int>>();
    public virtual ICollection<IdentityUserToken<int>> Tokens { get; } = new List<IdentityUserToken<int>>();



}