using MemberQfit.Web.Models;
using MemberQfit.Web.Service.IService;
using MemberQfit.Web.Utility;

namespace MemberQfit.Web.Service
{
    public class MemberService : IMemberService
    {
        private readonly IBaseService _baseService;
        public MemberService(IBaseService baseService)
        {
            _baseService = baseService;
        }

        public async Task<ResponseDTO?> GetAllMembersAsync()
        {
            return await _baseService.SendAsync(new RequestDTO()
            {
                ApiType = SD.ApiType.GET,
                Url = SD.MemberAPIBase + "/api/members",

            });

        }

        public async Task<ResponseDTO?> GetMemberAsync(string firstName)
        {
            return await _baseService.SendAsync(new RequestDTO()
            {
                ApiType = SD.ApiType.GET,
                Url = SD.MemberAPIBase + "/api/members/GetByName" + firstName,

            });

        }

        public async Task<ResponseDTO?> GetMemberByIdAsync(int id)
        {
            return await _baseService.SendAsync(new RequestDTO()
            {
                ApiType = SD.ApiType.GET,
                Url = SD.MemberAPIBase + "/api/members/" + id,

            });

        }

        public async Task<ResponseDTO?> CreateMemberAsync(MembersDTO membersDTO)
        {
            return await _baseService.SendAsync(new RequestDTO()
            {
                ApiType = SD.ApiType.POST,
                Url = SD.MemberAPIBase + "/api/members",
                Data = membersDTO

            });

        }

        public async Task<ResponseDTO?> UpdateMemberAsync(MembersDTO membersDTO)
        {
            return await _baseService.SendAsync(new RequestDTO()
            {
                ApiType = SD.ApiType.PUT,
                Url = SD.MemberAPIBase + "/api/members",
                Data = membersDTO

            });

        }

        public async Task<ResponseDTO?> DeleteMemberAsync(int id)
        {
            return await _baseService.SendAsync(new RequestDTO()
            {
                ApiType = SD.ApiType.DELETE,
                Url = SD.MemberAPIBase + "/api/members/" + id,

            });

        }












    }
}


