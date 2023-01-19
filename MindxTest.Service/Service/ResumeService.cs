using MindxTest.Infrastructure.Repositories;
using MindxTest.Model.Model;

namespace MindxTest.Service.Service
{
    public class ResumeService : IResumeService
    {
        private IResumeRepository _resumeRepository;
        public ResumeService(IResumeRepository resumeRepository)
        {
            _resumeRepository = resumeRepository;
        }
        public Resume CreateResume(Resume resume)
        {
            _resumeRepository.Insert(resume);
            _resumeRepository.Save();
            return resume;
        }

        public void DeleteResume(object resumeId)
        {
            _resumeRepository.Delete(resumeId);
            _resumeRepository.Save();
        }

        public Resume ReadResume(object resumeId)
        {
            var resume = _resumeRepository.GetById(resumeId);
            return resume;
        }

        public void UpdateResume(object resumeId, Resume resumeUpdated)
        {
            var resume = _resumeRepository.GetById(resumeId);
            resume = resumeUpdated;
            _resumeRepository.Update(resume);
            _resumeRepository.Save();
        }

        public IEnumerable<Resume> GetResumesWithId(int userId)
        {
            return _resumeRepository.GetResumesWithId(userId);
        }

        public IEnumerable<Resume> GetResumes()
        {
            return _resumeRepository.GetAll();
        }
    }
}