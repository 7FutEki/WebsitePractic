using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebsitePractic.Interfaces;
using WebsitePractic.Models;

namespace WebsitePractic.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRecordRepository _recordRepository;
        private readonly ITimeRepository _timeRepository;
        private readonly IDateRepository _dateRepository;

        public HomeController(IRecordRepository recordRepository, ITimeRepository timeRepository, IDateRepository dateRepository)
        {
            _recordRepository = recordRepository;
            _timeRepository = timeRepository;
            _dateRepository = dateRepository;
        }

        public async Task<IActionResult> Index()
        {
            List<Date> dates = await _dateRepository.GetAllDates();
            ViewBag.Dates = dates;

            List<Time> times = await _timeRepository.GetAllTimes();
            ViewBag.Times = times;
            return View();
        }

        [HttpPost]
        public string Index(string FIO, string selecttime, string selectdate)
        {
            Records records = new Records
            {
                FIO = FIO,
                Date = selectdate,
                Time = selecttime
            };
            _recordRepository.Add(records);
            return $"Вы, {FIO}, записаны на {selectdate}, {selecttime}";
        }

        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}