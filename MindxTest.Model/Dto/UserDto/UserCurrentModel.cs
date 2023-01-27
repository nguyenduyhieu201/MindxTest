namespace MindxTest.Model.Dto.UserDto
{
    public class UserCurrentModel : UserLoginModel
    {
        public string UserId { set; get; } = "";
        public string UserRole { set; get; } = "";
    }
}