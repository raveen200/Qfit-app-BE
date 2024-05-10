using AutoMapper;
using MemberQfit.Services.API.Data;
using MemberQfit.Services.API.Models;
using MemberQfit.Services.API.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace MemberQfit.Services.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MembersController : ControllerBase
    {
        private readonly AppDbContext _db;
        private ResponseDTO _response;
        private IMapper _mapper;

        public MembersController(AppDbContext db, IMapper mapper)
        {
            _db = db;
            _response = new ResponseDTO();
            _mapper = mapper;
        }

        [HttpGet]
        public ResponseDTO Get()
        {
            try
            {
                IEnumerable<Members> objList = _db.Members.ToList();
                _response.Result = _mapper.Map<IEnumerable<MembersDTO>>(objList);

            }
            catch (Exception ex)
            {
                _response.Message = ex.Message;
                _response.IsSuccess = false;

            }
            return _response;

        }

        [HttpGet]
        [Route("{id:int}")]
        public ResponseDTO Get(int id)
        {
            try
            {
                Members obj = _db.Members.First(u => u.Id == id);
                _response.Result = _mapper.Map<MembersDTO>(obj);

            }
            catch (Exception ex)
            {
                _response.Message = ex.Message;
                _response.IsSuccess = false;

            }
            return _response;

        }

        [HttpGet]
        [Route("GetByName/{FirstName}")]
        public ResponseDTO GetById(string FirstName)
        {
            try
            {
                Members obj = _db.Members.First(u => u.FirstName.ToLower() == FirstName.ToLower());
                if (obj == null)
                {
                    _response.IsSuccess = false;

                }

                _response.Result = _mapper.Map<MembersDTO>(obj);

            }
            catch (Exception ex)
            {
                _response.Message = ex.Message;
                _response.IsSuccess = false;

            }
            return _response;

        }

        [HttpPost]
        public ResponseDTO Post([FromBody] MembersDTO membersDTO)
        {
            try
            {
                Members obj = _mapper.Map<Members>(membersDTO);
                _db.Members.Add(obj);
                _db.SaveChanges();
               

                _response.Result = _mapper.Map<MembersDTO>(obj);

            }
            catch (Exception ex)
            {
                _response.Message = ex.Message;
                _response.IsSuccess = false;

            }
            return _response;

        }

        [HttpPut]
        public ResponseDTO Put([FromBody] MembersDTO membersDTO)
        {
            try
            {
                Members obj = _mapper.Map<Members>(membersDTO);
                _db.Members.Update(obj);
                _db.SaveChanges();


                _response.Result = _mapper.Map<MembersDTO>(obj);

            }
            catch (Exception ex)
            {
                _response.Message = ex.Message;
                _response.IsSuccess = false;

            }
            return _response;

        }


        [HttpDelete]
        public ResponseDTO Delete(int id)
        {
            try
            {
                Members obj = _db.Members.First(u => u.Id == id);
                _db.Members.Remove(obj);
                _db.SaveChanges();


              

            }
            catch (Exception ex)
            {
                _response.Message = ex.Message;
                _response.IsSuccess = false;

            }
            return _response;

        }


    }
}
