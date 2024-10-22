using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public DbSet<Pessoa> Pessoas { get; set; } = null!; // Use null! to suppress nullability warnings

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Database=pessoasdb;Username=admin;Password=admin123");
    }
}
