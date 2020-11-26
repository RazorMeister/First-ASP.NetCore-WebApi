namespace WebApplication.Models
{
    public class CharacterSkill
    {
        public Character Character { get; set; }
        public int CharacterId { get; set; }
        
        public Skill Skill { get; set; }
        public int SkillId { get; set; }
    }
}