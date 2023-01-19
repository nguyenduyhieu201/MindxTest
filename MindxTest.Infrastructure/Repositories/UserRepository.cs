using MindxTest.Infrastructure.Infrastructure;
using MindxTest.Model.Dto;
using MindxTest.Model.Model;

namespace MindxTest.Infrastructure.Repositories
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public User Authenticate(UserLoginModel userLoginModel)
        {
            var user = dbSet.FirstOrDefault(user => (user.Username == userLoginModel.Username
                                        && user.Password == userLoginModel.Password));
            return user;
        }
    }
}