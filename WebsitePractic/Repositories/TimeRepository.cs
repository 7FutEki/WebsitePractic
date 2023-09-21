using Microsoft.EntityFrameworkCore;
using WebsitePractic.Interfaces;
using WebsitePractic.Models;

namespace WebsitePractic.Repositories
{
    public class TimeRepository : ITimeRepository
    {
        private readonly ApplicationContext _db;

        public TimeRepository(ApplicationContext db)
        {
            _db = db;
        }
        

        public async Task<List<Time>> GetAllTimes()
        {
            return await _db.Times.ToListAsync();
        }
    }
}
