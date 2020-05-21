using System.Threading.Tasks;
using TextBasedRPG.Dtos.Character;
using TextBasedRPG.Dtos.CharacterSkill;
using TextBasedRPG.Models;

namespace TextBasedRPG.Services.CharacterSkillService
{
    public interface ICharacterSkillService
    {
        Task<ServiceResponse<GetCharacterDto>> AddCharacterSkill(AddCharacterSkillDto newCharacterSkill);
    }
}