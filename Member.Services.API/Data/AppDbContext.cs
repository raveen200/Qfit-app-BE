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

            /*modelBuilder.Entity<Members>().HasData(
                               new Members
                               {
                                   Id = 1,
                                   FirstName = "John",
                                   LastName = "Doe",
                                   Email = "john@gmail.com",
                                   MobileNumber = "0786589235",
                                   NIC = "12789V",
                                   Address = "No 1, Colombo",




                               }); 
            modelBuilder.Entity<Members>().HasData(
                             new Members
                             {

                                 Id = 2,
                                 FirstName = "Jane",
                                 LastName = "Deo",
                                 Email = "Luni@gmail.com",
                                 MobileNumber = "0786589235",
                                 NIC = "125679V",
                                 Address = "No 1, Negombo",

                             });
            modelBuilder.Entity<Members>().HasData(
                             new Members
                             {
                                 Id = 3,
                                 FirstName = "Sunil",
                                 LastName = "Gamage",
                                 Email = "Luni@gmail.com",
                                 MobileNumber = "0786589235",
                                 NIC = "991202548V",
                                 Address = "No 1, Dankotuwa",

                             }); */

            modelBuilder.Entity<Members>()
                .HasIndex(p => p.NIC)
                .IsUnique();







        }
    }
}
