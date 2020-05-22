using System.Linq;
using AutoMapper;
using TextBasedRPG.Dtos.Character;
using TextBasedRPG.Dtos.CharacterSkill;
using TextBasedRPG.Dtos.Fight;
using TextBasedRPG.Dtos.Weapon;
using TextBasedRPG.Models;

namespace TextBasedRPG
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            // ! Egress
            CreateMap<Character, GetCharacterDto>().ForMember(dto => dto.Skills, c => c.MapFrom(c => c.CharacterSkills.Select(cs => cs.Skill)));
            CreateMap<Weapon, GetWeaponDto>();
            CreateMap<Skill, GetSkillDto>();
            CreateMap<Character, HighscoreDTO>();
            // ! Ingress
            CreateMap<AddCharacterDto, Character>();
        }
    }
}