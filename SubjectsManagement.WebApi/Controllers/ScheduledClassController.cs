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
        public IActionResult AddScheduledClass([FromBody] ScheduledClassDto scheduledClassDto)
        {
            var result = _serv.AddScheduledClass(scheduledClassDto);
            return Ok(result);
        }

        [HttpDelete]
        public IActionResult DeleteScheduledClass([FromQuery] int id)
        {
            var result = _serv.DeleteScheduledClass(id);
            return Ok(result);
        }

        [HttpGet]
        public IActionResult GetAllScheduledClassess()
        {
            var result = _serv.GetAllScheduledClassess();
            return Ok(result);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetScheduledClass(int id)
        {
            var result = _serv.GetScheduledClass(id);
            return result == null ? NotFound() : Ok(result);
        }

        [HttpPut]
        public IActionResult UpdateScheduledClass([FromQuery] int id, [FromBody] ScheduledClassDto scheduledClassDto)
        {
            var result = _serv.UpdateScheduledClass(id, scheduledClassDto);
            return Ok(result);
        }
    }
}
