using Qfit.Service.AuthAPI.Models;

namespace Qfit.Service.AuthAPI.Service.IService
{
    public interface IJwtTokenGenerator
    {
        string GenerateToken(ApplicationUser  applicationUser, IEnumerable<string>roles);
    }
}
