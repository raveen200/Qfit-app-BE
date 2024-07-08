using MembershipQfit.Service.API.Data;
using MembershipQfit.Service.API.Models;
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

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult Get(int id)
        {
            try
            {
                var obj = _db.Memberships.First(u => u.MembershipId == id);
                return Ok(obj);

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }

        }

        [HttpPut]
        public IActionResult Put(Membership obj)
        {
            try
            {
                _db.Memberships.Update(obj);
                _db.SaveChanges();
                return Ok("Updated Successfully");

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }

        }


      

      

        [HttpPost]
        public IActionResult Post(Membership obj)
        {
            try
            {
                _db.Memberships.Add(obj);
                _db.SaveChanges();
                return Ok("Added Successfully");

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }

        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            try
            {
                var obj = _db.Memberships.First(u => u.MembershipId == id);
                _db.Memberships.Remove(obj);
                _db.SaveChanges();
                return Ok("Deleted Successfully");

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }

        }




    }
}
