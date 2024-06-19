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
  
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int GetRemainingDays()
        {
            return (EndDate - DateTime.Now).Days;
        }
    }
}
