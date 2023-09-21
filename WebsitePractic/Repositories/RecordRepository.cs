using Microsoft.EntityFrameworkCore;
using WebsitePractic.Interfaces;
using WebsitePractic.Models;

namespace WebsitePractic.Repositories
{
    public class RecordRepository : IRecordRepository
    {
        private readonly ApplicationContext _db;

        public RecordRepository(ApplicationContext db)
        {
            _db = db;
        }

        public bool Add(Records records)
        {
            _db.Add(records);
            return Save();
        }

        public async Task<List<Records>> GetAllRecordsAsync()
        {
            return await _db.Records.ToListAsync();
        }

        public bool Save()
        {
            var saved = _db.SaveChanges();
            return saved > 0 ? true : false;
        }
    }
}
