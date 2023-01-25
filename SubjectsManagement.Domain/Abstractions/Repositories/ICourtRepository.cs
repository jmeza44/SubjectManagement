using SubjectsManagement.Domain.Dtos;
using SubjectsManagement.Domain.Models;

namespace SubjectsManagement.Domain.Abstractions.Repositories
{
    public interface ICourtRepository
    {
        Court AddCourt(Court court);
        Court DeleteCourt(int id);
        List<Court> GetAllCourts();
        Court GetCourt(int id);
        Court UpdateCourt(int id, Court court);
    }
}
