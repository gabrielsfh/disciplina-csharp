using Microsoft.EntityFrameworkCore;

namespace aula12_TPH {

    public class AppDbContext : DbContext {
        public DbSet<Pessoa> Pessoas {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            optionsBuilder.UseSqlite("Data Source=pessoas.db");
        }

        // No método OnModelCreating, utilizamso HasDiscriminator para definir uma colunade discriminação, 
        // chamada PessoaTipo, que indica o tipio de pessoa (Aluno ou Professor) na tabela única 
        // Tabela única por Hierarquia (TPH - Table per Hierarchy)

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.Entity<Pessoa>()
                .HasDiscriminator<string>("PessoaTipo")
                .HasValue<Aluno>("Aluno")
                .HasValue<Professor>("Professor");
        }

    }
}