using System.Threading.Tasks;
using WebApplication.Dtos.Character;
using WebApplication.Dtos.Weapon;
using WebApplication.Models;

namespace WebApplication.Services.WeaponService
{
    public interface IWeaponService
    {
        Task<ServiceResponse<GetCharacterDto>> AddWeapon(AddWeaponDto newWeapon);
    }
}