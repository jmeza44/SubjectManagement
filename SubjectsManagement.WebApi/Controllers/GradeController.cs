using Microsoft.AspNetCore.Mvc;
using SubjectsManagement.Domain.Abstractions.Services;
using SubjectsManagement.Domain.Dtos;

namespace SubjectsManagement.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GradeController : ControllerBase
    {
        private readonly IGradeService _serv;

        public GradeController(IGradeService serv)
        {
            _serv = serv;
        }

        [HttpPost]
        public IActionResult AddGrade([FromBody] GradeDto gradeDto)
        {
            var result = _serv.AddGrade(gradeDto);
            return result != null ? Ok(result) : BadRequest(result);
        }

        [HttpDelete]
        public IActionResult DeleteGrade([FromQuery] int id)
        {
            var result = _serv.DeleteGrade(id);
            return result != null ? Ok(result) : NotFound(result);
        }

        [HttpGet]
        public IActionResult GetAllGrades()
        {
            var result = _serv.GetAllGrades();
            return Ok(result);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetGrade(int id)
        {
            var result = _serv.GetGrade(id);
            return result != null ? Ok(result) : NotFound(result);
        }

        [HttpPut]
        public IActionResult UpdateGrade([FromQuery] int id, [FromBody] GradeDto gradeDto)
        {
            var result = _serv.UpdateGrade(id, gradeDto);
            return result != null ? Ok(result) : NotFound(result);
        }
    }
}
