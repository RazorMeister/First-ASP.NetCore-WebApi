using System.Linq;
using AutoMapper;
using WebApplication.Dtos.Character;
using WebApplication.Dtos.Fight;
using WebApplication.Dtos.Skill;
using WebApplication.Dtos.Weapon;
using WebApplication.Models;

namespace WebApplication
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>()
                .ForMember(dto => dto.Skills, c => c.MapFrom(c => c.CharacterSkills.Select(cs => cs.Skill)));
            CreateMap<AddCharacterDto, Character>();
            CreateMap<Weapon, GetWeaponDto>();
            CreateMap<Skill, GetSkillDto>();
            CreateMap<Character, HighScoreDto>();
        }
    }
}