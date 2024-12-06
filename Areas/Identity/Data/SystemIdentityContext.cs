using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SystemIdentity.Areas.Identity.Data;
using SystemIdentity.Models;

namespace SystemIdentity.Data;

public class SystemIdentityContext : IdentityDbContext<SystemUser>
{
    public SystemIdentityContext(DbContextOptions<SystemIdentityContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }

public DbSet<SystemIdentity.Models.Car> Car { get; set; } = default!;
}
