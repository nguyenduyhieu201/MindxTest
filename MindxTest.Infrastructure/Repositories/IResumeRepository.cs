using MindxTest.Infrastructure.Infrastructure;
using MindxTest.Model.Model;

namespace MindxTest.Infrastructure.Repositories
{
    public interface IResumeRepository : IRepositoryBase<Resume>
    {
        public IEnumerable<Resume> GetResumesWithId (int userId);

    }
}