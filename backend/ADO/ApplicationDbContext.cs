using Microsoft.EntityFrameworkCore;
using Modelo;
using System;
using System.IO;

namespace ADO
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Alumno> Alumnos { get; set; }

        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

      

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Define las configuraciones de las entidades aquí
            modelBuilder.Entity<Alumno>().HasKey(a => a.id);
            modelBuilder.Entity<Alumno>().Property(a => a.nombre).HasColumnName("nombre");
            modelBuilder.Entity<Alumno>().Property(a => a.primerRegistro).HasColumnName("primerRegistro");
            modelBuilder.Entity<Alumno>().Property(a => a.correoPersonal).HasColumnName("correoPersonal");
            modelBuilder.Entity<Alumno>().Property(a => a.correoUdabol).HasColumnName("correoUdabol");
            modelBuilder.Entity<Alumno>().Property(a => a.codigo).HasColumnName("codigo");
            modelBuilder.Entity<Alumno>().Property(a => a.verificacion).HasColumnName("verificacion");
            modelBuilder.Entity<Alumno>().Property(a => a.isActive).HasColumnName("isActive").HasDefaultValueSql("false");
            modelBuilder.Entity<Alumno>().Property(a => a.ex_GIT_6PTS).HasColumnName("ex_GIT_6PTS");
            modelBuilder.Entity<Alumno>().Property(a => a.ex_ADOO_8PTS).HasColumnName("ex_ADOO_8PTS");
            modelBuilder.Entity<Alumno>().Property(a => a.ex_ScrumTra_41PTS).HasColumnName("ex_ScrumTra_41PTS");
            modelBuilder.Entity<Alumno>().Property(a => a.ex_SOLID_8PTS).HasColumnName("ex_SOLID_8PTS");
            modelBuilder.Entity<Alumno>().Property(a => a.ex_12FactApp_12PTS).HasColumnName("ex_12FactApp_12PTS");
            modelBuilder.Entity<Alumno>().Property(a => a.ex_Docker_5PTS).HasColumnName("ex_Docker_5PTS");
        }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=" + Path.Combine(Directory.GetCurrentDirectory(), "notas.db"));
        }
    }
}
