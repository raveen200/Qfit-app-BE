
using MembershipQfit.Service.API.Models;
using Microsoft.EntityFrameworkCore;

namespace MembershipQfit.Service.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Membership> Memberships { get; set; }

    


    }
}
