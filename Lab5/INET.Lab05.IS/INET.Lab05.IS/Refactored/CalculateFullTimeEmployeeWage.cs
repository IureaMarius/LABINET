using INET.Lab05.IS.Abstractions;
using INET.Lab05.IS.Refactored.Abstractions;

namespace INET.Lab05.IS.Refactored
{
    public class CalculateFullTimeEmployeeWage : IHasBenefits, IHasBonus, IHasMonthlyWage
    {
        public string Benefits()
        {
            return "Free meal at Fenice, for 2";
        }

        public decimal GetBonus()
        {
            return decimal.Multiply(GetMonthlyWage(), .2M);
        }

        public decimal GetMonthlyWage()
        {
            return 100;
        }
    }
}
