namespace MindxTest.Model.Model
{
    public class Information
    {
        public int InformationId { set; get; }
        public string Name { set; get; } = "";
        public string Email { set; get; } = "";
        public string Mobile { set; get; } = "";
        public string Github { set; get; } = "";
        public string Linkedin { set; get; } = "";
        public virtual Resume Resume { set; get; }


    }
}