using System.Threading.Tasks;
using WebApplication.Dtos.Character;
using WebApplication.Dtos.CharacterSkill;
using WebApplication.Models;

namespace WebApplication.Services.CharacterSkillService
{
    public interface ICharacterSkillService
    {
        Task<ServiceResponse<GetCharacterDto>> AddCharacterSkill(AddCharacterSkillDto newCharacterSkill);
    }
}