using WebsitePractic.Models;

namespace WebsitePractic.Interfaces
{
    public interface IDateRepository
    {
        Task<List<Date>> GetAllDates();
    }
}
