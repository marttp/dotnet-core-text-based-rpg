using AutoMapper;
using TextBasedRPG.Dtos.Character;
using TextBasedRPG.Dtos.Weapon;
using TextBasedRPG.Models;

namespace TextBasedRPG
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            // ! Egress
            CreateMap<Character, GetCharacterDto>();
            CreateMap<Weapon, GetWeaponDto>();
            // ! Ingress
            CreateMap<AddCharacterDto, Character>();
        }  
    }
}