using WebsitePractic.Models;

namespace WebsitePractic.Interfaces
{
    public interface ITimeRepository
    {
        Task<List<Time>> GetAllTimes();
    }
}
