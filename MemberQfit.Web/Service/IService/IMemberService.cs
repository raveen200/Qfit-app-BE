using MemberQfit.Web.Models;

namespace MemberQfit.Web.Service.IService
{
    public class IMemberService
    {
        Task<ResponseDTO?> GetMemberAsync(string firstName);
        Task<ResponseDTO?> GetAllMembersAsync();
        Task<ResponseDTO?> GetMemberByIdAsync(int id);
        Task<ResponseDTO?> CreateMemberAsync(MembersDTO membersDTO);
        Task<ResponseDTO?> UpdateMemberAsync(MembersDTO membersDTO);
        Task<ResponseDTO?> DeleteMemberAsync(int id);



    }
}
