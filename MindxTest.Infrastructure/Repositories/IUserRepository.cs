using MindxTest.Infrastructure.Infrastructure;
using MindxTest.Model.Dto.UserDto;
using MindxTest.Model.Model;

namespace MindxTest.Infrastructure.Repositories
{
    public interface IUserRepository : IRepositoryBase<User>
    {
        public User Authenticate(UserLoginModel userLoginModel);
        public IEnumerable<User> GetUsers();
    }
}