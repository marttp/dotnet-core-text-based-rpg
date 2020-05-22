using System.Collections.Generic;
using System.Threading.Tasks;
using TextBasedRPG.Dtos.Fight;
using TextBasedRPG.Dtos.Weapon;
using TextBasedRPG.Models;

namespace TextBasedRPG.Services.FightService
{
    public interface IFightService
    {
        Task<ServiceResponse<AttackResultDto>> WeaponAttack(WeaponAttackDto request);
        Task<ServiceResponse<AttackResultDto>> SkillAttack(SkillAttackDto request);
        Task<ServiceResponse<FightResultDto>> Fight(FightRequestDto request);
        Task<ServiceResponse<List<HighscoreDTO>>> GetHighscore();
    }
}