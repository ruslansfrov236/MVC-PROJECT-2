using System.ComponentModel.DataAnnotations;

namespace Task_16.Areas.admin.Data.Dto.Staticstic
{
    public class UpdateStatisticDto
    {
        public string? Id { get; set; }
     
        public decimal Statistic { get; set; }
      
        public string? StatisticsName { get; set; }
      
        public float StatisticsPercentage { get; set; }
      

        public DateTime StatisticsTime { get; set; }
      
        public string? StatisticsDuration { get; set; }
      
       
        public string? StatisticsVisit { get; set; }
      
        public string? StatisticsVisits { get; set; }
      
        public float StatisticsPercentages { get; set; }
      
        public float StatisticsPercent { get; set; }
    }
}
