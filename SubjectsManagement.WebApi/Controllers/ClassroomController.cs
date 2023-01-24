using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SubjectsManagement.Domain.Abstractions;
using SubjectsManagement.Domain.Dtos;

namespace SubjectsManagement.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassroomController : ControllerBase
    {
        private readonly ILogger<ClassroomController> _logger;
        private readonly IClassroomService _serv;

        public ClassroomController(ILogger<ClassroomController> logger, IClassroomService serv)
        {
            _logger = logger;
            _serv = serv;
        }

        [HttpPost]
        public IActionResult AddClassroom([FromBody] ClassroomDto classroom)
        {
            var _result = _serv.AddClassroom(classroom);
            if (_result.Result != null)
            {
                return Ok(_result);
            }
            return BadRequest(_result);
        }

        [HttpDelete]
        public IActionResult DeleteClassroom([FromQuery] int id)
        {
            var _result = _serv.DeleteClassroom(id);
            if (_result.Result != null)
            {
                return Ok(_result);
            }
            return NotFound(_result);
        }

        [HttpGet]
        public IActionResult GetAllClassrooms()
        {
            var _result = _serv.GetAllClassrooms();
            return Ok(_result);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetClassroom(int id)
        {
            var _result = _serv.GetClassroom(id);
            if (_result.Result != null)
            {
                return Ok(_result);
            }
            return NotFound(_result);
        }

        [HttpPut]
        public IActionResult UpdateClassroom([FromQuery] int id, [FromBody] ClassroomDto classroom)
        {
            var _result = _serv.UpdateClassroom(id, classroom);
            if (_result.Result != null)
            {
                return Ok(_result);
            }
            return NotFound(_result);
        }
    }
}
