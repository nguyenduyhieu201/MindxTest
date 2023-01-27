using MindxTest.Infrastructure.Infrastructure;
using MindxTest.Model.Dto.UserDto;
using MindxTest.Model.Model;

namespace MindxTest.Infrastructure.Repositories
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        private IResumeRepository _resumeRepository;
        public UserRepository(MindxDbContext _context, IResumeRepository _resumeRepository) : base(_context)
        {
            this._resumeRepository = _resumeRepository;
        }

        public User Authenticate(UserLoginModel userLoginModel)
        {
            var user = dbSet.FirstOrDefault(user => (user.Username == userLoginModel.Username
                                        && user.Password == userLoginModel.Password));
            return user;
        }

        public IEnumerable<User> GetUsers()
        {
            var users = GetAll();
            foreach (var user in users) { 
                user.Resumes = _resumeRepository.GetResumesWithId(user.UserId).ToList();
            }
            return users;
        }
    }
}