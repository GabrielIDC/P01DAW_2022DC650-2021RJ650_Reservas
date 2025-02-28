using Microsoft.EntityFrameworkCore;
using P01DAW_2022DC650_2021RJ650_Reservas.Models;

namespace P01DAW_2022DC650_2021RJ650_Reservas.Data
{
    public class ParqueosDbContext : DbContext
    {
        public ParqueosDbContext(DbContextOptions<ParqueosDbContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Sucursal> Sucursales { get; set; }
        public DbSet<Parqueo> Parqueos { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
    }
}
