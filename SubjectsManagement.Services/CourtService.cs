using SubjectsManagement.Domain.Abstractions.Repositories;
using SubjectsManagement.Domain.Abstractions.Services;
using SubjectsManagement.Domain.Dtos;
using SubjectsManagement.Domain.Models;

namespace SubjectsManagement.Services
{
    public class CourtService : ICourtService
    {
        private readonly ICourtRepository _repo;

        public CourtService(ICourtRepository repo)
        {
            _repo = repo;
        }

        public Court AddCourt(CourtDto courtDto)
        {
            var court = _repo.AddCourt((Court)courtDto);
            return court;
        }

        public Court DeleteCourt(int id)
        {
            var court = _repo.DeleteCourt(id);
            return court;
        }

        public List<Court> GetAllCourts()
        {
            var court = _repo.GetAllCourts();
            return court;
        }

        public Court GetCourt(int id)
        {
            var court = _repo.GetCourt(id);
            return court;
        }

        public Court UpdateCourt(int id, CourtDto courtDto)
        {
            var court = _repo.UpdateCourt(id, (Court)courtDto);
            return court;
        }
    }
}
