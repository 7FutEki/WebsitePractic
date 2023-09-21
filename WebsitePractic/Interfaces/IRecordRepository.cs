using WebsitePractic.Models;

namespace WebsitePractic.Interfaces
{
    public interface IRecordRepository
    {
        bool Add(Records records);
        bool Save();
        Task<List<Records>> GetAllRecordsAsync();
        
    }
}
