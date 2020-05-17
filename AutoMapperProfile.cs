using AutoMapper;
using TextBasedRPG.Dtos.Character;
using TextBasedRPG.Models;

namespace TextBasedRPG
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            // ! Egress
            CreateMap<Character, GetCharacterDto>();
            // ! Ingress
            CreateMap<AddCharacterDto, Character>();
        }  
    }
}