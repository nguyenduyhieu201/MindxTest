using MindxTest.Infrastructure.Repositories;
using MindxTest.Model.Dto.ResumeDto;
using MindxTest.Model.Dto.UserDto;
using MindxTest.Model.Model;
using MindxTest.Service.Extension;

namespace MindxTest.Service.Service
{
    public class ResumeService : IResumeService
    {
        private IResumeRepository _resumeRepository;
        private IUserRepository _userRepository;
        public ResumeService(IResumeRepository resumeRepository, IUserRepository userRepository)
        {
            _resumeRepository = resumeRepository;
            _userRepository = userRepository;
        }
        public Resume CreateResume(ResumeCreateDto resumeCreateDto, UserCurrentModel userCurrentModel)
        {
            var resume = new Resume();
            var user = _userRepository.GetById(Int32.Parse(userCurrentModel.UserId));
            resume.CreateResume(resumeCreateDto, user);
            user.Resumes.Add(resume);
            _resumeRepository.Insert(resume);
            _resumeRepository.Save();
            _userRepository.Update(user);
            _userRepository.Save();
            return resume;
        }

        public void DeleteResume(object resumeId)
        {
            _resumeRepository.Delete(resumeId);
            _resumeRepository.Save();
        }

        public ResumeViewModel ReadResume(object resumeId)
        {
            var resume = _resumeRepository.GetById(resumeId);
            var resumeViewModel = new ResumeViewModel();
            resumeViewModel.ReadResume(resume);
            return resumeViewModel;
        }

        public void UpdateResume(object resumeId, ResumeUpdateModel resumeUpdateModel)
        {
            var resume = _resumeRepository.GetById(resumeId);
            resume.UpdateResume(resumeUpdateModel);
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