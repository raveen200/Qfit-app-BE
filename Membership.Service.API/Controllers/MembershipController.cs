using MembershipQfit.Service.API.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MembershipQfit.Service.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MembershipController : ControllerBase
    {
        private readonly  AppDbContext _db;

        public MembershipController(AppDbContext db)
        {
            _db = db;
        }


        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var objList = _db.Memberships.ToList();
                return Ok(objList);

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }

        }


    }
}
