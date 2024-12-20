using Microsoft.EntityFrameworkCore;
using PrimeiraAPI.Model;

namespace PrimeiraAPI.Infrastructure
{
    public class ConnectionContext : DbContext
    {
        public DbSet<Customer> Customer { get; set; }

        public ConnectionContext(DbContextOptions<ConnectionContext> options)
            : base(options)
        {
        }
    }
}
