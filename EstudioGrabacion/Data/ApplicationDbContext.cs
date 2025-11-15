using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using EstudioGrabacion.Models;

namespace EstudioGrabacion.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Ingeniero> Ingenieros { get; set; }
        public DbSet<Servicio> Servicios { get; set; }
        public DbSet<Sesion> Sesiones { get; set; }
        public DbSet<Paquete> Paquetes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Paquete>()
                .HasMany(p => p.Servicios)
                .WithMany(s => s.Paquetes)
                .UsingEntity(j => j.ToTable("PaqueteServicios"));

            modelBuilder.Entity<Sesion>()
                .HasOne(s => s.Ingeniero)
                .WithMany(i => i.Sesiones)
                .HasForeignKey(s => s.IngenieroId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Sesion>()
                .HasOne(s => s.Servicio)
                .WithMany(serv => serv.Sesiones)
                .HasForeignKey(s => s.ServicioId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
} // ← Asegúrate de que esta llave de cierre esté