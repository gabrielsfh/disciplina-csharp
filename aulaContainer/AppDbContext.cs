using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public DbSet<Pessoa> Pessoas { get; set; } = null!; 

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Database=pessoadb;Username=admin;Password=admin123");
    }
}
