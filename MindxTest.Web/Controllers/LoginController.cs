using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using MindxTest.Model.Dto;
using MindxTest.Model.Model;
using MindxTest.Service.Service;

namespace MindxTest.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
        private IConfiguration _config;
        private IUserService _userService;

        public LoginController(IConfiguration config, UserService userService)
        {
            _config = config;
            _userService = userService;
        }
        [HttpPost]
        [Route("login")]
        public IActionResult Login([FromBody] UserLoginModel userLoginModel)
        {
            var user = _userService.Authenticate(userLoginModel);
            if (user != null)
            {
                var token = Generate(user);
                return Ok(token);
            }
            return NotFound("User not found");
        }
        [HttpPost]
        [Route("signup")]

        public IActionResult SignUp([FromBody] UserSignUpModel userSignUpModel)
        {
            var user = _userService.SignUp(userSignUpModel);
            return Ok();
        }
        private string Generate(User user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Secret"]));
            var credential = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[] {
                new Claim(ClaimTypes.NameIdentifier, user.Username),
                new Claim(ClaimTypes.Role, user.UserRole.ToString())
            };

            var token = new JwtSecurityToken(_config["Jwt:ValidIssuer"],
            _config["Jwt:ValidAudience"],
            claims,
            expires: DateTime.Now.AddMinutes(120),
            signingCredentials: credential);
            return new JwtSecurityTokenHandler().WriteToken(token);
        }


    }
}