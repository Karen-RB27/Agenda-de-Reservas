using Microsoft.EntityFrameworkCore;
using AgendaDeReservas.Models;

namespace AgendaDeReservas.DATA
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Reserva> Reservas { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}