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
        Student student = new Student();
        student.Name = requestModel.Name;
        student.Surname = requestModel.Surname;
        student.Email = requestModel.Email;
        student.Phone = requestModel.Phone;
        student.BirthDate = requestModel.BirthDate;

        _context.Students.Add(student);
        _context.SaveChanges();

        return Ok();
    }
}
