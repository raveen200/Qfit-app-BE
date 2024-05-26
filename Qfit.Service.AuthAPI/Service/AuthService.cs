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
        private readonly IJwtTokenGenerator _jwtTokenGenerator;


        public AuthService(AppDbContext db, IJwtTokenGenerator jwtTokenGenerator,
            UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _db = db;
            _jwtTokenGenerator = jwtTokenGenerator;
            _userManager = userManager;
            _roleManager = roleManager;

        }

        public async Task<bool> AssignRole(string email, string roleName)
        {
            var user = _db.ApplicationUsers.FirstOrDefault(u => u.Email.ToLower() == email.ToLower());
            if (user != null)
            {
                if (!_roleManager.RoleExistsAsync(roleName).GetAwaiter().GetResult())
                {
                    _roleManager.CreateAsync(new IdentityRole(roleName)).GetAwaiter().GetResult();
                }
                await _userManager.AddToRoleAsync(user, roleName);
                return true;
            }
            return false;
        }

        public async Task<LoginResponseDTO> login(LoginReqeustDTO loginReqeustDTO)
        {

            var user = _db.ApplicationUsers.FirstOrDefault(u => u.UserName.ToLower() == loginReqeustDTO.UserName.ToLower());

            bool isValid = await _userManager.CheckPasswordAsync(user, loginReqeustDTO.Password);

            if (user == null || isValid == false)
            {
                return new LoginResponseDTO() { Member = null, Token = "" };
            }
            var roles = await _userManager.GetRolesAsync(user);
            var token = _jwtTokenGenerator.GenerateToken(user,roles);

            MemberDTO memberDTO = new()
            {
                Email = user.Email,
                Id = user.Id,
                Name = user.Name,
                PhoneNumber = user.PhoneNumber

            };
            LoginResponseDTO loginResponseDTO = new LoginResponseDTO()
            {
                Member = memberDTO,
                Token = token   
            };

            return loginResponseDTO;


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
