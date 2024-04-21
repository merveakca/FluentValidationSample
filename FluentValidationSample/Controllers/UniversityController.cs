using FluentValidationSample.Models.DTO;
using FluentValidationSample.Models.ORM;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FluentValidationSample.Controllers;
[Route("api/[controller]")]
[ApiController]
public class UniversityController : ControllerBase
{
    AkademiIstanbulContext _context;
    public UniversityController()
    {
        _context = new AkademiIstanbulContext();
    }

    [HttpPost]
    public IActionResult AddUniversity(AddUniversityRequestDto request)
    {
        University university = new University();
        university.Name = request.Name;
        university.City = request.City;

        _context.Universities.Add(university);
        _context.SaveChanges();

        return Ok(request);
    }

    [HttpPut("{id}")]
    public IActionResult UpdateUniversity(int id, UpdateUniversityRequestDto request)
    {
        University university = _context.Universities.FirstOrDefault(x => x.ID == id);
        if (university == null)
        {
            return NotFound();
        }

        university.Name = request.Name;
        university.City = request.City;
        return Ok(request);
    }
}
