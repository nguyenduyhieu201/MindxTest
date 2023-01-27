using MindxTest.Model.Dto.ResumeDto;
using MindxTest.Model.Dto.UserDto;
using MindxTest.Model.Model;

namespace MindxTest.Service.Service
{
    public interface IResumeService
    {
        public Resume CreateResume(ResumeCreateDto resumeCreateDto, UserCurrentModel user);
        public ResumeViewModel ReadResume(object resumeId);
        public void UpdateResume(object resumeId, ResumeUpdateModel resumeUpdateModel);
        public void DeleteResume(object resumeId);
        public IEnumerable<Resume> GetResumesWithId(int userId);
        public IEnumerable<Resume> GetResumes();


    }
}