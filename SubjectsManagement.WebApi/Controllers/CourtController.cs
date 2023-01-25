using Microsoft.AspNetCore.Mvc;
using SubjectsManagement.Domain.Abstractions.Services;
using SubjectsManagement.Domain.Dtos;

namespace SubjectsManagement.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourtController : ControllerBase
    {
        private readonly ICourtService _serv;

        public CourtController(ICourtService serv)
        {
            _serv = serv;
        }

        [HttpPost]
        public IActionResult AddCourt([FromBody] CourtDto courtDto)
        {
            var result = _serv.AddCourt(courtDto);
            return result != null ? Ok(result) : BadRequest(result);
        }

        [HttpDelete]
        public IActionResult DeleteCourt([FromQuery] int id)
        {
            var result = _serv.DeleteCourt(id);
            return result != null ? Ok(result) : NotFound(result);
        }

        [HttpGet]
        public IActionResult GetAllCourts()
        {
            var result = _serv.GetAllCourts();
            return Ok(result);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetCourt(int id)
        {
            var result = _serv.GetCourt(id);
            return result != null ? Ok(result) : NotFound(result);
        }

        [HttpPut]
        public IActionResult UpdateCourt([FromQuery] int id, [FromBody] CourtDto courtDto)
        {
            var result = _serv.UpdateCourt(id, courtDto);
            return result != null ? Ok(result) : NotFound(result);
        }
    }
}
