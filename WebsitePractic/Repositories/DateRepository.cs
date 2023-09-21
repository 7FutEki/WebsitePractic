using Microsoft.EntityFrameworkCore;
using WebsitePractic.Interfaces;
using WebsitePractic.Models;

namespace WebsitePractic.Repositories
{
    public class DateRepository : IDateRepository
    {
        private readonly ApplicationContext _db;

        public DateRepository(ApplicationContext db)
        {
            _db = db;
        }
        

        public async Task<List<Date>> GetAllDates()
        {
            return await _db.Dates.ToListAsync();
        }
    }
}
