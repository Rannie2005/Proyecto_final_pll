using Microsoft.EntityFrameworkCore;
using Studio.Domain.Entities;

namespace Studio.Infrastructure.Context
{
    public class StudioContext : DbContext
    {
        public StudioContext(DbContextOptions<StudioContext> options) : base(options) { }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Engineer> Engineers { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Paquete> Paquetes { get; set; }
    }
}
