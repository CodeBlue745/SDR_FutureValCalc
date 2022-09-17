using System.ComponentModel.DataAnnotations;

namespace FutureValue.Models
{/// <summary>
/// The FutureValueModel contains two functions. The first is a formula for a futureValue.
///The second returns a formatted math formula as a string.
/// </summary>
    public class FutureValueModel
    {
        //Declare all variables
        public decimal MonthlyInvestment { get; set; }
        public decimal YearlyInterestRate { get; set; }//Allow variable to pass in and out of the model
        public int Years { get; set; }
        /// <summary>
        /// This function calculates the Future Value.
        /// </summary>
        /// <returns></returns>
        public decimal CalculateFutureValue()
        {
            //Declare three local variables.
            int months = Years * 12;
            decimal monthlyInterestRate = YearlyInterestRate / 12 / 100;//Chop up the year into months and make it a percentage.
            decimal futureValue = 0;
            //Make sure we include each month in the calculation.
            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + MonthlyInvestment) *
                                (1 + monthlyInterestRate);
            }
            //Return the decimal value.
            return futureValue;
        }/// <summary>
        /// This function creates a formatted string.
        /// </summary>
        /// <returns></returns>
        public string ReturnMathFormula()
        {
            //First, declare a local variable.
            int yr = Years;
            //Next, declare two formatted local variables.
            string mInvest = MonthlyInvestment.ToString("C2");
            string yrU = (YearlyInterestRate).ToString("C2");
            //Last, create the formatted string.
            string numberInputs = "Solution = (" + mInvest + "Investment/month * (1 + " + yrU + "Yearly Interest Rate Unit / 12 / 100)) * (" + yr + "yr(s) * 12)";
            return numberInputs;//return the string.
        }
    }
}
