using System.ComponentModel.DataAnnotations;

namespace Task_16.Areas.admin.Data.Dto.Staticstic
{
    public class CreateStatisticDto
    {
          
        [Required(ErrorMessage = "Zorunlu alan ")]
        public decimal Statistic { get; set; }
        [Required(ErrorMessage = "Zorunlu alan ")]
        public string? StatisticsName { get; set; }
        [Required(ErrorMessage = "Zorunlu alan ")]
        public float StatisticsPercentage { get; set; }
        [Required(ErrorMessage = "Zorunlu alan ")]

        public DateTime StatisticsTime { get; set; }
        [Required(ErrorMessage = "Zorunlu alan ")]
        public string? StatisticsDuration { get; set; }
        [Required(ErrorMessage = "Zorunlu alan ")]
       
        public string? StatisticsVisit { get; set; }
        [Required(ErrorMessage = "Zorunlu alan ")]
        public string? StatisticsVisits { get; set; }
        [Required(ErrorMessage = "Zorunlu alan ")]
        public float StatisticsPercentages { get; set; }
        [Required(ErrorMessage = "Zorunlu alan ")]
        public float StatisticsPercent { get; set; }
    }
}
