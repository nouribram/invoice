using invoice.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace invoice.Services
{
    public class ApplicationDbContext : DbContext 
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) 
        {
           
        }

        public DbSet<Invoice> Invoices { get; set; } = null!;

    }
}
