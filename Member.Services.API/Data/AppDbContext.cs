using MemberQfit.Services.API.Models;
using Microsoft.EntityFrameworkCore;

namespace MemberQfit.Services.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Members> Members { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Members>().HasData(
                               new Members
                               {
                                   Id = 1,
                                   FirstName = "John",
                                   LastName = "Doe",
                                   Email = "john@gmail.com",
                                

                               });
            modelBuilder.Entity<Members>().HasData(
                             new Members
                             {
                                 Id = 2,
                                 FirstName = "Jane",
                                 LastName = "Deo",
                                 Email = "Luni@gmail.com",
                               

                             });
        }
    }
}
