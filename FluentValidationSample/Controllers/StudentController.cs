using FluentValidationSample.Models.DTO;
using FluentValidationSample.Models.ORM;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FluentValidationSample.Controllers;
[Route("api/[controller]")]
[ApiController]
public class StudentController : ControllerBase
{
    AkademiIstanbulContext _context;
    public StudentController()
    {
        _context = new AkademiIstanbulContext();
    }

    [HttpPost]
    public IActionResult AddStudent(CreateStudentRequestDto requestModel)
    {
        return Ok();
    }
}
