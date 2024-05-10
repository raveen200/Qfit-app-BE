namespace MemberQfit.Services.API.Models.DTO
{
    public class MembersDTO
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? MobileNumber { get; set; }
        public string? NIC { get; set; }
        public string? Address { get; set; }
        public DateOnly? JoinDate { get; set; } = DateOnly.FromDateTime(DateTime.Now);
    }

}
