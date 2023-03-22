using API.Model.Dto;
using API.Model.Models;
using AutoMapper;

namespace ProjectAPI.Mapper
{
    public class AutoMapper : Profile
    {
        public AutoMapper() 
        {
            CreateMap<UserUpdateDto, User>().ReverseMap();
        }
    }
}
