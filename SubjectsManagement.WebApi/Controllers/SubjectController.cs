using Microsoft.AspNetCore.Mvc;
using SubjectsManagement.Domain.Abstractions;
using SubjectsManagement.Domain.Dtos;

namespace SubjectsManagement.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectController : ControllerBase
    {
        private readonly ISubjectService _serv;

        public SubjectController(ISubjectService serv)
        {
            _serv = serv;
        }

        [HttpPost]
        public IActionResult AddSubject([FromBody] SubjectDto subjectDto)
        {
            var result = _serv.AddSubject(subjectDto);
            return Ok(result);
        }

        [HttpDelete]
        public IActionResult DeleteSubject([FromQuery] int id)
        {
            var result = _serv.DeleteSubject(id);
            return Ok(result);
        }

        [HttpGet]
        public IActionResult GetAllSubjects()
        {
            var result = _serv.GetAllSubjects();
            return Ok(result);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetSubject(int id)
        {
            var result = _serv.GetSubject(id);
            return result == null ? NotFound() : Ok(result);
        }

        [HttpPut]
        public IActionResult UpdateSubject([FromQuery] int id, [FromBody] SubjectDto subjectDto)
        {
            var result = _serv.UpdateSubject(id, subjectDto);
            return Ok(result);
        }
    }
}
