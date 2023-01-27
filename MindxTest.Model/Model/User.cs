using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using MindxTest.Model.Enum;

namespace MindxTest.Model.Model
{
    public class User
    {
        public int UserId { set; get; }
        public string Username { set; get; } = "";
        public string Password { set; get; } = "";
        [EnumDataType(typeof(UserType))]
        public UserType UserRole { set; get; }
        public ICollection<Resume> Resumes { set; get; } = new Collection<Resume>();
    }
}