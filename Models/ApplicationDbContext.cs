using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace MyMvcApi.Models;

public class ApplicationDbContext : IdentityDbContext<AppUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        foreach(var entityType in builder.Model.GetEntityTypes()){
            var tableName = entityType.GetTableName();
        if (tableName != null && tableName.StartsWith("AspNet"))
        {
            entityType.SetTableName(tableName.Substring(6));
        }
        }
    }
}
