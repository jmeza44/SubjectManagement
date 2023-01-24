using Microsoft.AspNetCore.Mvc;
using SubjectsManagement.Domain.Abstractions;
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
            if (result.Result != null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpDelete]
        public IActionResult DeleteSemester([FromQuery] int id)
        {
            var result = _serv.DeleteSemester(id);
            if (result.Result != null)
            {
                return Ok(result);
            }
            return NotFound(result);
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
            if (result.Result != null)
            {
                return Ok(result);
            }
            return NotFound(result);
        }

        [HttpPut]
        public IActionResult UpdateSemester([FromQuery] int id, [FromBody] SemesterDto semester)
        {
            var result = _serv.UpdateSemester(id, semester);
            if (result.Result != null)
            {
                return Ok(result);
            }
            return NotFound(result);
        }
    }
}
