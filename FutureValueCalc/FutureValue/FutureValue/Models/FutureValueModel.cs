using System.ComponentModel.DataAnnotations;

namespace FutureValue.Models
{
    public class FutureValueModel
    {//Below are the errors that display on-screen, when the app runs.
        [Required(ErrorMessage = "Please enter a monthly investment.")]//The entry is not put in.
        [Range(1, 500, ErrorMessage =
               "Monthly investment amount must be between 1 and 500.")]
        public decimal? MonthlyInvestment { get; set; }

        [Required(ErrorMessage = "Please enter a yearly interest rate.")]//This entry is missed.
        [Range(0.1, 10.0, ErrorMessage =
               "Yearly interest rate must be between 0.1 and 10.0.")]//or this entry is not formatted properly
        public decimal? YearlyInterestRate { get; set; }

        [Required(ErrorMessage = "Please enter a number of years.")]//This entry is missed
        [Range(1, 50, ErrorMessage =
               "Number of years must be between 1 and 50.")]//or the count is not correct.
        public int? Years { get; set; }
        /// <summary>
        /// This method will calculate and return a future value
        /// </summary>
        /// <returns></returns>
        public decimal? CalculateFutureValue()
        {//each variable is nullable.
            int? months = Years * 12;//calculate months
            decimal? monthlyInterestRate = YearlyInterestRate / 12 / 100;//formula for monthlyInterestRate.
            decimal? futureValue = 0;//set to 0
            //for every item within the months.
            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + MonthlyInvestment) *
                                (1 + monthlyInterestRate);//Overall formula
            }
            return futureValue;//return value to view
        }
    }
}
