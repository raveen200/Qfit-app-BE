using MemberQfit.Services.API.Models.Enums;

namespace MemberQfit.Services.API.Models.DTO
{
    public class MembersAllProptiesDTO
    {

        public int Id { get; set; }

        public string NIC { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string MobileNumber { get; set; }

        public string? Address { get; set; }

        public DateOnly JoinDate { get; set; } = DateOnly.FromDateTime(DateTime.Now);

        public StatusEnum Status { get; set; } = StatusEnum.Active;
        public string? Job { get; set; }
        public string? City { get; set; }
        public string? AboutMe { get; set; }
        public int? Age { get; set; }
        public GenderEnum? Gender { get; set; }
        public double? Height { get; set; }
        public double? Weight { get; set; }
    }

}
