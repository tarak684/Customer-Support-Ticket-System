using Microsoft.EntityFrameworkCore;
using System.Net.Sockets;
using TicketSystem.API.Models;

namespace TicketSystem.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }

        public DbSet<User> Users { get; set; }


    }
}
