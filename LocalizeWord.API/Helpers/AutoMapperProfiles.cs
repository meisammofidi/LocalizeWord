using AutoMapper;
using LocalizeWord.API.Dto;
using LocalizeWord.API.Models;

namespace LocalizeWord.API.Helpers
{
    public class AutoMapperProfiles: Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<User, UserDetailsDto>();
        }
    }
}