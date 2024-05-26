using Qfit.Service.AuthAPI.Models.DTO;

namespace Qfit.Service.AuthAPI.Service.IService
{
    public interface IAuthService
    {
        Task<string> Register(RegistarationRequsetDTO registarationRequsetDTO);
        Task<LoginResponseDTO> login(LoginReqeustDTO loginReqeustDTO);
        Task<bool> AssignRole(string email, string roleName);
    }
}
