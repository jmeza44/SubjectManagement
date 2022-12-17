using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SubjectsManagement.Domain.Abstractions;
using SubjectsManagement.Domain.Models;

namespace SubjectsManagement.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly ISubjectRepository _repo;

        public SubjectController(ILogger<WeatherForecastController> logger, ISubjectRepository repo)
        {
            _logger = logger;
            _repo = repo;
        }

        [HttpPost(Name = "AddSubject")]
        public IActionResult AddSubject(Subject subject)
        {
            var _subject = _repo.AddSubject(subject);
            return Ok(_subject);
        }

        [HttpGet(Name = "GetSubject")]
        public IActionResult GetSubject(int id)
        {
            var _subject = _repo.GetSubject(id);
            return _subject == null ? NotFound() : Ok(_subject);
        }
    }
}
