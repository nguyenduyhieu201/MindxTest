using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using MindxTest.Model.Dto.UserDto;
using MindxTest.Model.Model;

namespace MindxTest.Service.Extension
{
    public static class UserEntityExtension
    {
        public static void SignUp(this User user, UserSignUpModel userSignUpModel)
        {
            user.Username = userSignUpModel.Username;
            user.Password = userSignUpModel.Password;
            user.UserRole = Model.Enum.UserType.User;
            user.Resumes = new Collection<Resume>();
        }
    }
}