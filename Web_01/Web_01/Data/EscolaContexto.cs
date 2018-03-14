using Microsoft.EntityFrameworkCore;

namespace Web_01.Data
{
    public class EscolaContexto : DbContext
    {
        public EscolaContexto(DbContextOptions<EscolaContexto> options) : base(options)
        {
        }

        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Matricula> Matriculas { get; set; }
        public DbSet<Estudante> Estudantes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Curso>().ToTable("Curso");
            modelBuilder.Entity<Matricula>().ToTable("Matricula");
            modelBuilder.Entity<Estudante>().ToTable("Estudante");
        }
    }
}
