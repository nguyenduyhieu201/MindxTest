namespace MindxTest.Model.Dto.ResumeDto
{
    public class ResumeCreateDto
    {
        public string Summary { set; get; }
        #region education
        public string University { set; get; } = "";
        public string Falcuty { set; get; } = "";
        public string Gpa { set; get; } = "";
        #endregion

        #region experience
        public string JobTitle { set; get; } = "";
        public string Company { set; get; } = "";
        public string Period { set; get; } = "";
        public string JobDescription { set; get; } = "";
        #endregion

        #region information
        public string Name { set; get; } = "";
        public string Email { set; get; } = "";
        public string Mobile { set; get; } = "";
        public string Github { set; get; } = "";
        public string Linkedin { set; get; } = "";
        #endregion

        #region skill
        public string Language { set; get; } = "";
        public string SoftSkill { set; get; } = "";
        #endregion



    }
}