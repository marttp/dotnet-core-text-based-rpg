using System.Collections.Generic;

namespace TextBasedRPG.Models
{
    public class Skill
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Damage { get; set; }
        public List<CharacterSkill> CharacterSkills { get; set; }
    }
}