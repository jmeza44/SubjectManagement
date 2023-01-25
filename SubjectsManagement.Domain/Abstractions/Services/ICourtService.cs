using SubjectsManagement.Domain.Dtos;
using SubjectsManagement.Domain.Models;

namespace SubjectsManagement.Domain.Abstractions.Services
{
    public interface ICourtService
    {
        Court AddCourt(CourtDto courtDto);
        Court DeleteCourt(int id);
        List<Court> GetAllCourts();
        Court GetCourt(int id);
        Court UpdateCourt(int id, CourtDto courtDto);
    }
}
