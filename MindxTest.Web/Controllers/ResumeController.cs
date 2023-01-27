using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MindxTest.Model.Dto.ResumeDto;
using MindxTest.Model.Dto.UserDto;
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
    [Authorize(Roles = "Admin,User")]
    public IActionResult CreateResume(ResumeCreateDto resumeCreateDto)
    {
        var user = GetCurrentUser();
        _resumeService.CreateResume(resumeCreateDto, user);
        return Ok();
    }

    [HttpGet]
    [Authorize(Roles = "Admin,User")]
    public IActionResult ReadResume([FromQuery] int resumeId)
    {
        return Ok(_resumeService.ReadResume(resumeId));
    }

    [HttpPut]
    [Authorize(Roles = "Admin,User")]

    public IActionResult UpdateResume([FromQuery] int resumeId, ResumeUpdateModel resumeUpdateModel)
    {
        _resumeService.UpdateResume(resumeId, resumeUpdateModel);
        return Ok();
    }

    [HttpDelete]
    [Authorize(Roles = "Admin,User")]

    public void DeleteResume([FromQuery] int resumeId)
    {
        _resumeService.DeleteResume(resumeId);
    }

    private UserCurrentModel GetCurrentUser()
    {
        var identity = HttpContext.User.Identity as ClaimsIdentity;

        if (identity != null)
        {
            var userClaims = identity.Claims;

            return new UserCurrentModel
            {
                UserId = userClaims.FirstOrDefault(o => o.Type == ClaimTypes.Sid)?.Value,
                Username = userClaims.FirstOrDefault(o => o.Type == ClaimTypes.NameIdentifier)?.Value,
                UserRole = userClaims.FirstOrDefault(o => o.Type == ClaimTypes.Role)?.Value == "Admin" ?
                 "Admin" : "User"
            };
        }
        return null;
    }
}
