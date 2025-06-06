using Microsoft.EntityFrameworkCore;
using DA_S.Models;


namespace DA_S.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options) 
        {

        }
        public DbSet<DiaryEntry> DiaryEntries {  get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<DiaryEntry>().HasData(
              
                new DiaryEntry { 
                    Id = 1,
                    Title="Daily deadlines",
                    Content="ASP - C# - React - JS", 
                    Created = DateTime.Now
                }, 

                new DiaryEntry
                {
                    Id = 2,
                    Title = "Deadlines",
                    Content = "sub1 - sub2 - sub3",
                    Created = DateTime.Now,
                },
            );
        }
    }
}
