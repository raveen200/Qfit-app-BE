
using MembershipQfit.Service.API.Models;
using MembershipQfit.Service.API.Models.Enums;
using Microsoft.EntityFrameworkCore;

namespace MembershipQfit.Service.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Membership> Memberships { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

           /* modelBuilder.Entity<Membership>().HasData(
                                  new Membership
                                  {
                                      MembershipId = 1,
                                      NIC = "12789V",
                                      MembershipType = MembershipType.Monthly,
                                      StartDate = new System.DateTime(2021, 1, 1),
                                      EndDate = new System.DateTime(2021, 1, 31),
                                      RemainingDays = 30


                                  });

            modelBuilder.Entity<Membership>().HasData(
                new Membership
                {
                    MembershipId = 2,
                    NIC = "125679V",
                    MembershipType = MembershipType.Monthly,
                    StartDate = new System.DateTime(2021, 1, 1),
                    EndDate = new System.DateTime(2021, 12, 31),
                    RemainingDays = 30
                });
            modelBuilder.Entity<Membership>().HasData(
                new Membership
                {
                    MembershipId = 3,
                    NIC = "991202548V",
                    MembershipType = MembershipType.Monthly,
                    StartDate = new System.DateTime(2021, 1, 1),
                    EndDate = new System.DateTime(2021, 12, 31),
                    RemainingDays = 30
                }); */



        }



        public void ReduceRemainingDays()
        {
            var memberships = Memberships.ToList();
            foreach (var membership in memberships)
            {
                if (membership.RemainingDays > 0)
                {
                    membership.RemainingDays -= 1;
                }
            }
            SaveChanges();
        }

    }
}
