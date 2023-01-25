using Microsoft.AspNetCore.Mvc;
using SubjectsManagement.Domain.Abstractions.Services;
using SubjectsManagement.Domain.Dtos;

namespace SubjectsManagement.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly ITeacherService _serv;

        public TeacherController(ITeacherService serv)
        {
            _serv = serv;
        }

        [HttpPost]
        public IActionResult AddTeacher([FromBody] TeacherDto teacherDto)
        {
            var result = _serv.AddTeacher(teacherDto);
            return result != null ? Ok(result) : BadRequest(result);
        }

        [HttpDelete]
        public IActionResult DeleteTeacher([FromQuery] int id)
        {
            var result = _serv.DeleteTeacher(id);
            return result != null ? Ok(result) : NotFound(result);
        }

        [HttpGet]
        public IActionResult GetAllTeachers()
        {
            var result = _serv.GetAllTeachers();
            return Ok(result);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetTeacher(int id)
        {
            var result = _serv.GetTeacher(id);
            return result != null ? Ok(result) : NotFound(result);
        }

        [HttpPut]
        public IActionResult UpdateTeacher([FromQuery] int id, [FromBody] TeacherDto teacherDto)
        {
            var result = _serv.UpdateTeacher(id, teacherDto);
            return result != null ? Ok(result) : NotFound(result);
        }
    }
}
