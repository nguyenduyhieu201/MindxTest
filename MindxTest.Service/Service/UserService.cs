using MindxTest.Infrastructure.Repositories;
using MindxTest.Model.Dto.UserDto;
using MindxTest.Model.Model;
using MindxTest.Service.Extension;


namespace MindxTest.Service.Service
{
    public class UserService : IUserService
    {
        private IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public User SignUp(UserSignUpModel userSignUp)
        {
            var user = new User();
            user.SignUp(userSignUp);
            _userRepository.Insert(user);
            _userRepository.Save();
            return user;
        }

        public IEnumerable<User> GetUsers()
        {
            return _userRepository.GetUsers();
        }

        public User Authenticate(UserLoginModel userLoginModel)
        {
            var user = _userRepository.Authenticate(userLoginModel);
            return user;
        }
    }
}