using Microsoft.EntityFrameworkCore;

namespace aula12_TPC {

    public class AppDbContext : DbContext {
        public DbSet<Pessoa> Pessoas {get; set;}
        public DbSet<Aluno> Alunos {get; set;}
        public DbSet<Professor> Professores {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            optionsBuilder.UseSqlite("Data Source=pessoas.db");
        }

        // No método OnModelCreating, utilizamso HasDiscriminator para definir uma colunade discriminação, 
        // chamada PessoaTipo, que indica o tipio de pessoa (Aluno ou Professor) na tabela única 
        // Tabela única por Hierarquia (TPH - Table per Hierarchy)


        // criando uma lista de alunos e professores (cair na prova)
        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.Entity<Aluno>().ToTable("AlunoTPC");
            modelBuilder.Entity<Professor>().ToTable("ProfessoresTPC");
        }

    }
}