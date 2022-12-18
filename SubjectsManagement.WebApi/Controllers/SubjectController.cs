using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SubjectsManagement.Domain.Abstractions;
using SubjectsManagement.Domain.Dtos;

namespace SubjectsManagement.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectController : ControllerBase
    {
        private readonly ILogger<SubjectController> _logger;
        private readonly ISubjectService _serv;

        public SubjectController(ILogger<SubjectController> logger, ISubjectService serv)
        {
            _logger = logger;
            _serv = serv;
        }

        [HttpPost]
        public IActionResult AddSubject(SubjectDto subject)
        {
            var _subject = _serv.AddSubject(subject);
            return Ok(_subject);
        }

        [HttpDelete("{id:int}")]
        public IActionResult DeleteSubject(int id)
        {
            var _subject = _serv.DeleteSubject(id);
            return Ok(_subject);
        }

        [HttpGet]
        public IActionResult GetAllSubjects()
        {
            var _subjects = _serv.GetAllSubjects();
            return Ok(_subjects);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetSubject(int id)
        {
            var _subject = _serv.GetSubject(id);
            return _subject == null ? NotFound() : Ok(_subject);
        }

        [HttpPut("{id:int}")]
        public IActionResult UpdateSubject(int id, SubjectDto subject)
        {
            var _subject = _serv.UpdateSubject(id, subject);
            return Ok(_subject);
        }
    }
}
