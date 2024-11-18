using AutoMapper;
using workshop.Dtos;
using workshop.Entities;

namespace workshop.Helpers
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<UserDto,User>().ReverseMap();
        }
    }
}
