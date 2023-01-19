using Microsoft.AspNetCore.Mvc;
using MindxTest.Model.Model;
using MindxTest.Service.Service;

namespace MindxTest.Web.Controllers;

[ApiController]
[Route("[controller]")]
public class ResumeController : ControllerBase
{
    private readonly IResumeService _resumeService;
    private readonly ILogger<ResumeController> _logger;

    public ResumeController(ILogger<ResumeController> logger, IResumeService resumeService)
    {
        _logger = logger;
        _resumeService = resumeService;
    }

    [HttpPost]
    public IActionResult CreateResume(Resume resume)
    {
        _resumeService.CreateResume(resume);
        return Ok();
    }

    [HttpGet]
    [Route("{id}")]
    public Resume ReadResume(object resumeId)
    {
        return _resumeService.ReadResume(resumeId);
    }

    [HttpPut]
    public void UpdateResume([FromQuery] object resumeId, Resume resumeUpdated)
    {
        _resumeService.UpdateResume(resumeId, resumeUpdated);
    }

    [HttpDelete]
    public void DeleteResume(object resumeId)
    {
        _resumeService.DeleteResume(resumeId);
    }
}
