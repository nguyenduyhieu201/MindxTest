namespace MindxTest.Model.Model
{
    public class Skill
    {
        public int SkillId { set; get; }
        public string Language { set; get; } = "";
        public string SoftSkill { set; get; } = "";
        public virtual Resume Resume { set; get; }
    }
}