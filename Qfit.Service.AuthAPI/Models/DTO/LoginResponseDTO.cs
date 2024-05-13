namespace Qfit.Service.AuthAPI.Models.DTO
{
    public class LoginResponseDTO
    {
        public MemberDTO Member { get; set; }
        public string Token { get; set; }
    }
}
