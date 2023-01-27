using MindxTest.Model.Dto.ResumeDto;
using MindxTest.Model.Model;

namespace MindxTest.Service.Extension
{
    public static class ResumeEntityExtension
    {
        public static void CreateResume(this Resume resume, ResumeCreateDto resumeCreateDto, User user)
        {
            resume.Summary = resumeCreateDto.Summary;
            resume.University = resumeCreateDto.University;
            resume.Falcuty = resumeCreateDto.Falcuty;
            resume.Gpa = resumeCreateDto.Gpa;
            resume.JobTitle = resumeCreateDto.JobTitle;
            resume.Company = resumeCreateDto.Company;
            resume.Period = resumeCreateDto.Period;
            resume.JobDescription = resumeCreateDto.JobDescription;
            resume.Name = resumeCreateDto.Name;
            resume.Email = resumeCreateDto.Email;
            resume.Mobile = resumeCreateDto.Mobile;
            resume.Github = resumeCreateDto.Github;
            resume.Linkedin = resumeCreateDto.Linkedin;
            resume.Language = resumeCreateDto.Language;
            resume.SoftSkill = resumeCreateDto.SoftSkill;
            resume.User = user;
            resume.UserId = user.UserId;
        }

        public static void ReadResume(this ResumeViewModel resumeViewModel, Resume resume)
        {
            resumeViewModel.Summary = resume.Summary;
            resumeViewModel.University = resume.University;
            resumeViewModel.Falcuty = resume.Falcuty;
            resumeViewModel.Gpa = resume.Gpa;
            resumeViewModel.JobTitle = resume.JobTitle;
            resumeViewModel.Company = resume.Company;
            resumeViewModel.Period = resume.Period;
            resumeViewModel.JobDescription = resume.JobDescription;
            resumeViewModel.Name = resume.Name;
            resumeViewModel.Email = resume.Email;
            resumeViewModel.Mobile = resume.Mobile;
            resumeViewModel.Github = resume.Github;
            resumeViewModel.Linkedin = resume.Linkedin;
            resumeViewModel.Language = resume.Language;
            resumeViewModel.SoftSkill = resume.SoftSkill;
        }

        public static void UpdateResume(this Resume resume, ResumeUpdateModel resumeUpdateModel)
        {
            resume.Summary = resumeUpdateModel.Summary;
            resume.University = resumeUpdateModel.University;
            resume.Falcuty = resumeUpdateModel.Falcuty;
            resume.Gpa = resumeUpdateModel.Gpa;
            resume.JobTitle = resumeUpdateModel.JobTitle;
            resume.Company = resumeUpdateModel.Company;
            resume.Period = resumeUpdateModel.Period;
            resume.JobDescription = resumeUpdateModel.JobDescription;
            resume.Name = resumeUpdateModel.Name;
            resume.Email = resumeUpdateModel.Email;
            resume.Mobile = resumeUpdateModel.Mobile;
            resume.Github = resumeUpdateModel.Github;
            resume.Linkedin = resumeUpdateModel.Linkedin;
            resume.Language = resumeUpdateModel.Language;
            resume.SoftSkill = resumeUpdateModel.SoftSkill;
        }
    }
}