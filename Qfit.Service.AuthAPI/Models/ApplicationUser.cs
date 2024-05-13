using Microsoft.AspNetCore.Identity;

namespace Qfit.Service.AuthAPI.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
