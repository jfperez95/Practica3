using Microsoft.EntityFrameworkCore;
using Practica2.Web.Models;
namespace Practica2.Web.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Municipio> Municipios { get; set; }

        public DbSet<Barrio> Barrios { get; set; }

        public DbSet<Alumno> Alumnos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Municipio>()
                .HasIndex(M => M.Nombre)
                .IsUnique();

            modelBuilder.Entity<Barrio>()
                .HasIndex(B => B.Nombre)
                .IsUnique();

            modelBuilder.Entity<Alumno>()
                .HasIndex(A => A.Documento)
                .IsUnique();
        }
    }
}
