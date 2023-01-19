using System.ComponentModel.DataAnnotations.Schema;

namespace MindxTest.Model.Model
{
    public class Resume
    {
        public int ResumeId { set; get; }
        [ForeignKey("User")]

        public int UserId { set; get; }
        [ForeignKey("Information")]

        public int InformationId { set; get; }
        [ForeignKey("Experience")]

        public int ExperienceId
        {
            set; get;
        }
        [ForeignKey("Education")]

        public int EducationId { set; get; }
        [ForeignKey("Skill")]

        public int SkillId { set; get; }
        public virtual User User { set; get; }
        public string Summary { set; get; }
        public virtual Information Information { set; get; }
        public virtual Experience Experience { set; get; }
        public virtual Education Education { set; get; }
        public virtual Skill Skill { set; get; }

    }
}