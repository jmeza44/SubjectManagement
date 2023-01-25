using Microsoft.AspNetCore.Mvc;
using SubjectsManagement.Domain.Abstractions.Services;
using SubjectsManagement.Domain.Dtos;

namespace SubjectsManagement.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SemesterController : ControllerBase
    {
        private readonly ISemesterService _serv;
        public SemesterController(ISemesterService serv)
        {
            _serv = serv;
        }

        [HttpPost]
        public IActionResult AddSemester([FromBody] SemesterDto semester)
        {
            var result = _serv.AddSemester(semester);
            return result != null ? Ok(result) : BadRequest(result);
        }

        [HttpDelete]
        public IActionResult DeleteSemester([FromQuery] int id)
        {
            var result = _serv.DeleteSemester(id);
            return result != null ? Ok(result) : NotFound(result);
        }

        [HttpGet]
        public IActionResult GetAllSemesters()
        {
            var result = _serv.GetAllSemesters();
            return Ok(result);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetSemester(int id)
        {
            var result = _serv.GetSemester(id);
            return result != null ? Ok(result) : NotFound(result);
        }

        [HttpPut]
        public IActionResult UpdateSemester([FromQuery] int id, [FromBody] SemesterDto semester)
        {
            var result = _serv.UpdateSemester(id, semester);
            return result != null ? Ok(result) : NotFound(result);
        }
    }
}
