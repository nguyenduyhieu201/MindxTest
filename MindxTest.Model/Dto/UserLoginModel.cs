using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MindxTest.Model.Dto
{
    public class UserLoginModel
    {
        public string Username { set; get; } = "";
        public string Password { set; get; } = "";
    }
}