using System.ComponentModel.DataAnnotations;

namespace MemberQfit.Services.API.Models
{
    public class Members
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
 








    }
}
