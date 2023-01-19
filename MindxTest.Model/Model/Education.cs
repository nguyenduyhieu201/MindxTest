namespace MindxTest.Model.Model
{
    public class Education
    {
        public int EducationId { set; get; }
        public string University { set; get; } = "";
        public string Falcuty { set; get; } = "";
        public string Gpa { set; get; } = "";
        public virtual Resume Resume { set; get; }

    }
}