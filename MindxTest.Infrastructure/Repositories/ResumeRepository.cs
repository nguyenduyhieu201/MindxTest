using MindxTest.Infrastructure.Infrastructure;
using MindxTest.Model.Model;

namespace MindxTest.Infrastructure.Repositories
{
    public class ResumeRepository : RepositoryBase<Resume>, IResumeRepository
    {
        public ResumeRepository(MindxDbContext context) : base(context)
        {
        }

        public IEnumerable<Resume> GetResumesWithId(int userId)
        {
            var resumeList = GetAll();
            return resumeList.Where(resume => resume.UserId == userId);
        }
    }
}