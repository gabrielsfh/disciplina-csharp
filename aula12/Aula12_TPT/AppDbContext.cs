using Microsoft.EntityFrameworkCore;

namespace aula12_TPT {

    public class AppDbContext : DbContext {
        public DbSet<Pessoa> Pessoas {get; set;}
        public DbSet<Aluno> Alunos {get; set;}
        public DbSet<Professor> Professores {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            optionsBuilder.UseSqlite("Data Source=pessoas.db");
        }

        // No método OnModelCreating, utilizamso HasDiscriminator para definir uma colunade discriminação, 
        // chamada PessoaTipo, que indica o tipoo de pessoa (Aluno ou Professor) na tabela única 
        // Tabela única por Hierarquia (TPH - Table per Hierarchy)

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.Entity<Aluno>().ToTable("Alunos");
            modelBuilder.Entity<Professor>().ToTable("Professores");
        }

    }
}