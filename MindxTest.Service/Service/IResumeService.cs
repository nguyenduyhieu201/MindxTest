using MindxTest.Model.Model;

namespace MindxTest.Service.Service
{
    public interface IResumeService
    {
        public Resume CreateResume(Resume resume);
        public Resume ReadResume(object resumeId);
        public void UpdateResume(object resumeId, Resume resumeUpdated);
        public void DeleteResume(object resumeId);
        public IEnumerable<Resume> GetResumesWithId(int userId);
        public IEnumerable<Resume> GetResumes();


    }
}