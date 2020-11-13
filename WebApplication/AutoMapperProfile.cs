using AutoMapper;
using WebApplication.Dtos.Character;
using WebApplication.Models;

namespace WebApplication
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>();
            CreateMap<AddCharacterDto, Character>();
        }
    }
}