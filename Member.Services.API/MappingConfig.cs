using AutoMapper;
using MemberQfit.Services.API.Models;
using MemberQfit.Services.API.Models.DTO;

namespace MemberQfit.Services.API
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<MembersDTO, Members>();
                config.CreateMap<Members, MembersDTO>();




                config.CreateMap<MembersAllProptiesDTO, Members>();
                config.CreateMap<Members, MembersAllProptiesDTO>();
            });
            return mappingConfig;






        }

    }
}
