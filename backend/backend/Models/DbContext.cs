using System;
using Microsoft.EntityFrameworkCore;

namespace backend.Models
{
    public class ReservaDbContext : DbContext
    {
        public ReservaDbContext(DbContextOptions<ReservaDbContext> options) : base(options)
        {
        }

        public DbSet<Reserva> Reservas { get; set; }
    }
}

