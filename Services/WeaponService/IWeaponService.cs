using System.Threading.Tasks;
using TextBasedRPG.Dtos.Character;
using TextBasedRPG.Dtos.Weapon;
using TextBasedRPG.Models;

namespace TextBasedRPG.Services.WeaponService
{
    public interface IWeaponService
    {
         Task<ServiceResponse<GetCharacterDto>> AddWeapon(AddWeaponDto newWeapon);
    }
}