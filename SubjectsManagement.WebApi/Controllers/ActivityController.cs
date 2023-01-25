using Microsoft.AspNetCore.Mvc;
using SubjectsManagement.Domain.Abstractions.Services;
using SubjectsManagement.Domain.Dtos;

namespace SubjectsManagement.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActivityController : ControllerBase
    {
        private readonly IActivityService _serv;

        public ActivityController(IActivityService serv)
        {
            _serv = serv;
        }

        [HttpPost]
        public IActionResult AddActivity([FromBody] ActivityDto activityDto)
        {
            var result = _serv.AddActivity(activityDto);
            return result != null ? Ok(result) : BadRequest(result);
        }

        [HttpDelete]
        public IActionResult DeleteActivity([FromQuery] int id)
        {
            var result = _serv.DeleteActivity(id);
            return result != null ? Ok(result) : NotFound(result);
        }

        [HttpGet]
        public IActionResult GetAllActivities()
        {
            var result = _serv.GetAllActivities();
            return Ok(result);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetActivity(int id)
        {
            var result = _serv.GetActivity(id);
            return result != null ? Ok(result) : NotFound(result);
        }

        [HttpPut]
        public IActionResult UpdateActivity([FromQuery] int id, [FromBody] ActivityDto activityDto)
        {
            var result = _serv.UpdateActivity(id, activityDto);
            return result != null ? Ok(result) : NotFound(result);
        }
    }
}
