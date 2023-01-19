using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MindxTest.Model.Dto;
using MindxTest.Model.Model;

namespace MindxTest.Service.Service
{
    public interface IUserService
    {
        public User SignUp(UserSignUpModel userSignUp);
        public IEnumerable<User> GetUsers();
        public User Authenticate(UserLoginModel userLoginModel);
    }
}