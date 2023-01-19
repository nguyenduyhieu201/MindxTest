namespace MindxTest.Model.Model
{
    public class Experience
    {
        public int ExperienceId { set; get; }
        public string JobTitle { set; get; } = "";
        public string Company { set; get; } = "";
        public string Period { set; get; } = "";
        public string JobDescription { set; get; } = "";
        public virtual Resume Resume { set; get; }

    }
}