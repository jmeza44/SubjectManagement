using Microsoft.AspNetCore.Mvc;
using SubjectsManagement.Domain.Abstractions;
using SubjectsManagement.Domain.Dtos;

namespace SubjectsManagement.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScheduledClassController : ControllerBase
    {
        private readonly IScheduledClassService _serv;

        public ScheduledClassController(IScheduledClassService serv)
        {
            _serv = serv;
        }

        [HttpPost]
        public IActionResult AddScheduledClass([FromBody] ScheduledClassDto scheduledClass)
        {
            var _scheduledClass = _serv.AddScheduledClass(scheduledClass);
            return Ok(_scheduledClass);
        }

        [HttpDelete]
        public IActionResult DeleteScheduledClass([FromQuery] int id)
        {
            var _subject = _serv.DeleteScheduledClass(id);
            return Ok(_subject);
        }

        [HttpGet]
        public IActionResult GetAllScheduledClassess()
        {
            var _subjects = _serv.GetAllScheduledClassess();
            return Ok(_subjects);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetScheduledClass(int id)
        {
            var _subject = _serv.GetScheduledClass(id);
            return _subject == null ? NotFound() : Ok(_subject);
        }

        [HttpPut]
        public IActionResult UpdateScheduledClass([FromQuery] int id, [FromBody] ScheduledClassDto scheduledClass)
        {
            var _subject = _serv.UpdateScheduledClass(id, scheduledClass);
            return Ok(_subject);
        }
    }
}
