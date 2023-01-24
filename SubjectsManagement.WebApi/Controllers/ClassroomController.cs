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
        private readonly IClassroomService _serv;

        public ClassroomController(IClassroomService serv)
        {
            _serv = serv;
        }

        [HttpPost]
        public IActionResult AddClassroom([FromBody] ClassroomDto classroomDto)
        {
            var result = _serv.AddClassroom(classroomDto);
            if (result.Result != null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpDelete]
        public IActionResult DeleteClassroom([FromQuery] int id)
        {
            var result = _serv.DeleteClassroom(id);
            if (result.Result != null)
            {
                return Ok(result);
            }
            return NotFound(result);
        }

        [HttpGet]
        public IActionResult GetAllClassrooms()
        {
            var result = _serv.GetAllClassrooms();
            return Ok(result);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetClassroom(int id)
        {
            var result = _serv.GetClassroom(id);
            if (result.Result != null)
            {
                return Ok(result);
            }
            return NotFound(result);
        }

        [HttpPut]
        public IActionResult UpdateClassroom([FromQuery] int id, [FromBody] ClassroomDto classroomDto)
        {
            var result = _serv.UpdateClassroom(id, classroomDto);
            if (result.Result != null)
            {
                return Ok(result);
            }
            return NotFound(result);
        }
    }
}
