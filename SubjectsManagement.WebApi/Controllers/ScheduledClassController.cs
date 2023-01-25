using Microsoft.AspNetCore.Mvc;
using SubjectsManagement.Domain.Abstractions.Services;
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
            return result != null ? Ok(result) : BadRequest(result);
        }

        [HttpDelete]
        public IActionResult DeleteScheduledClass([FromQuery] int id)
        {
            var result = _serv.DeleteScheduledClass(id);
            return result != null ? Ok(result) : NotFound(result);
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
            return result != null ? Ok(result) : NotFound(result);
        }

        [HttpPut]
        public IActionResult UpdateScheduledClass([FromQuery] int id, [FromBody] ScheduledClassDto scheduledClassDto)
        {
            var result = _serv.UpdateScheduledClass(id, scheduledClassDto);
            return result != null ? Ok(result) : NotFound(result);
        }
    }
}
