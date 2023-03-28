using System.ComponentModel.DataAnnotations;

namespace Tip_Calculator.Models
{
    public class TipCalculatorModel
    {
        [Required(ErrorMessage = "Please enter a meal price.")]
        [Range(1, 500, ErrorMessage =
              "The meal price must be greater than 0 and less than 500")]
        public decimal? SalesPrice { get; set; }

        public decimal? CalculateFifteen()
        {
            return SalesPrice * 0.15m;
        }
        public decimal? CalculateTwenty()
        {
            return SalesPrice * 0.20m;
        }
        public decimal? CalculateTwentyFive()
        {
            return SalesPrice * 0.25m;
        }
    }
}
