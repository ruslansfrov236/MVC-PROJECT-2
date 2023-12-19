using Microsoft.AspNetCore.Mvc;
using Task_16.Areas.admin.Data.Dto.Staticstic;
using Task_16.Areas.admin.Models.Entities;
using Task_16.Context;

namespace Task_16.Areas.admin.Controllers
{
    [Area("Admin")]
    public class FormsController : Controller
    {
        readonly private Task16DbContext _context;
        public FormsController(Task16DbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> CreateForm()
        {

            return View();
        }


        [HttpPost]
        public async Task<IActionResult> CreateForm(CreateStatisticDto model)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("CreateForm");
            }
            Statistics statistics = new Statistics()
            {
                Statistic = model.Statistic,
                StatisticsName = model.StatisticsName,
                StatisticsPercentage = model.StatisticsPercentage,
                StatisticsDuration = model.StatisticsDuration,
                StatisticsPercent = model.StatisticsPercent,
                StatisticsPercentages = model.StatisticsPercentages,
                StatisticsTime = model.StatisticsTime,
                StatisticsVisit = model.StatisticsVisit,
                StatisticsVisits = model.StatisticsVisits
            };
           

            await _context.Statistics.AddAsync(statistics);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index", "Dashboard");


        }

        [HttpGet]
        public async Task<IActionResult> UpdateForm()
        {

            return View();
        }


        [HttpPut]
        public async Task<IActionResult> UpdateForm(UpdateStatisticDto model)
        {

            var id = await _context.Statistics.FindAsync( model.Id);

            if (id != null)
            {
                Statistics statistics = new Statistics();

                statistics.Statistic = model.Statistic;
                statistics.StatisticsName = model.StatisticsName;
                statistics.StatisticsPercentage = model.StatisticsPercentage;
                statistics.StatisticsDuration = model.StatisticsDuration;
                statistics.StatisticsPercent = model.StatisticsPercent;
                statistics.StatisticsTime = model.StatisticsTime;
                statistics.StatisticsVisit = model.StatisticsVisit;
                statistics.StatisticsVisits = model.StatisticsVisits;
                statistics.StatisticsTime = model.StatisticsTime;

                await _context.Statistics.AddAsync(statistics); 
                await _context.SaveChangesAsync();
            }
               

          


            return RedirectToAction("Index", "Tables");


        }

        [HttpDelete]
        public async Task <IActionResult> DeleteForm(string id)
        {
            Statistics? statistics = await _context.Statistics.FindAsync( Guid.Parse(id))  ;

            
             _context.Statistics.Remove(statistics);  
              await _context.SaveChangesAsync() ;
           
             return RedirectToAction("Index", "Tables");
        }
    }


}
