using Microsoft.EntityFrameworkCore;
using AuthApp.Models;

namespace AuthApp.Data;

public class AppDbContext : DbContext
{
    public DbSet<User> Users => Set<User>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql
            (
            "Host=localhost;" +
            "Port=5432;" +
            "Username=postgres;" +
            "Password=@Mukhtor#24;" +
            "Database=authapp"
            );
    }
}
