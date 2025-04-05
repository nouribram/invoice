using Microsoft.EntityFrameworkCore;

namespace invoice.Services
{
    public class ApplicationDbContext : DbContext 
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) 
        {
        }

    }
}
