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
}