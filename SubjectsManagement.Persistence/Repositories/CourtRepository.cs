using SubjectsManagement.Domain.Abstractions.Repositories;
using SubjectsManagement.Domain.Models;

namespace SubjectsManagement.Persistence.Repositories
{
    public class CourtRepository : ICourtRepository
    {
        private readonly AppDbContext _context;
        public CourtRepository(AppDbContext context)
        {
            _context = context;
        }

        public Court AddCourt(Court court)
        {
            var courtAdded = _context.Add(court);
            _context.SaveChanges();
            return courtAdded.Entity;
        }

        public Court DeleteCourt(int id)
        {
            var courtDeleted = _context.Courts.FirstOrDefault(c => c.Id == id);
            if (courtDeleted != null)
            {
                _context.Courts.Remove(courtDeleted);
                _context.SaveChanges();
            }
            return courtDeleted;
        }

        public List<Court> GetAllCourts()
        {
            return _context.Courts.ToList();
        }

        public Court GetCourt(int id)
        {
            var court = _context.Courts.FirstOrDefault(c => c.Id == id);
            return court;
        }

        public Court UpdateCourt(int id, Court court)
        {
            var courtUpdated = _context.Courts.FirstOrDefault(c => c.Id == id);
            if (courtUpdated != null)
            {
                courtUpdated.Name = court.Name;
                _context.SaveChanges();
            }
            return courtUpdated;
        }
    }
}
