using Microsoft.AspNetCore.Identity;
using Qfit.Service.AuthAPI.Data;
using Qfit.Service.AuthAPI.Models;
using Qfit.Service.AuthAPI.Models.DTO;
using Qfit.Service.AuthAPI.Service.IService;

namespace Qfit.Service.AuthAPI.Service
{
    public class AuthService : IAuthService
    {

        private readonly AppDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;


        public AuthService(AppDbContext db, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _db = db;
            _userManager = userManager;
            _roleManager = roleManager;
        }


        public Task<LoginResponseDTO> login(LoginReqeustDTO loginReqeustDTO)
        {
            throw new NotImplementedException();
        }

        public async Task<string> Register(RegistarationRequsetDTO registarationRequsetDTO)
        {
            ApplicationUser user = new()
            {
                UserName = registarationRequsetDTO.Email,
                Email = registarationRequsetDTO.Email,
                NormalizedEmail = registarationRequsetDTO.Email.ToUpper(),
                Name = registarationRequsetDTO.Name,
                PhoneNumber = registarationRequsetDTO.PhoneNumber,


            };

            try
            {
                var result = await _userManager.CreateAsync(user, registarationRequsetDTO.Password);
                if (result.Succeeded)
                {
                    var userToReturn = _db.ApplicationUsers.First(u => u.UserName == registarationRequsetDTO.Email);

                    MemberDTO memberDTO = new()
                    {
                        Id = userToReturn.Id,
                        Name = userToReturn.Name,
                        Email = userToReturn.Email,
                        PhoneNumber = userToReturn.PhoneNumber
                    };

                    return "";

                }
                else
                {
                   return result.Errors.FirstOrDefault().Description;
                }
            }
            catch (Exception ex)
            {

            }

            return "An error occurred while registering the user. Please try again.";


        }
    }
}
