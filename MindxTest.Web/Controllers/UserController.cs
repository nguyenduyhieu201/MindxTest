using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MindxTest.Model.Model;
using MindxTest.Service.Service;

namespace MindxTest.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private IConfiguration _config;
        private ILogger<UserController> _logger;
        private IUserService _userService;

        public UserController(IConfiguration config, IUserService userService, ILogger<UserController> logger)
        {
            _config = config;
            _userService = userService;
            _logger = logger;
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IEnumerable<User> GetUsers()
        {
            return _userService.GetUsers();
        }

        private User GetCurrentUser()
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            if (identity != null)
            {
                var userClaims = identity.Claims;

                return new User
                {
                    Username = userClaims.FirstOrDefault(o => o.Type == ClaimTypes.NameIdentifier)?.Value,
                    UserRole = userClaims.FirstOrDefault(o => o.Type == ClaimTypes.Role)?.Value == "Admin" ?
                     Model.Enum.UserType.Admin : Model.Enum.UserType.User,
                };
            }
            return null;
        }
    }
}