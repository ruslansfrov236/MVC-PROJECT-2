using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Task_16.Areas.admin.Models.Entities;
using Task_16.Context;


namespace Task_16.Areas.admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {

        readonly private Task16DbContext _context;
        public DashboardController(Task16DbContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> Index()
        {

            var statistic = await _context.Statistics.Select(s =>
             new Statistics()
             {
                 Statistic = s.Statistic,
                 StatisticsName = s.StatisticsName,
                 StatisticsPercentage = s.StatisticsPercentage,
                 StatisticsDuration=s.StatisticsDuration,
                 StatisticsVisit=s.StatisticsVisit,
                 StatisticsVisits=s.StatisticsVisits,
                 StatisticsTime=s.StatisticsTime,
                 StatisticsPercent=s.StatisticsPercent,
                 StatisticsPercentages=s.StatisticsPercentages,

             }).ToListAsync();

            return View(statistic);
        }
    }
}
