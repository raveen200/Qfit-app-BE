using MembershipQfit.Service.API.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace MembershipQfit.Service.API.Models
{
    public class Membership
    {
        [Key]
        public int MembershipId { get; set; }

        public string NIC { get; set; }

        public MembershipType MembershipType { get; set; }

        public DateOnly StartDate { get; set; } = DateOnly.FromDateTime(DateTime.Now);

        public DateOnly EndDate { get; set; }

        public int RemainingDays { get; set; }

    }
}
