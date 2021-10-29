using System;
using INET.Lab05.IS.Abstractions;
using INET.Lab05.IS.Refactored.Abstractions;

namespace INET.Lab05.IS.Refactored
{
    public class CalculateFreelancerWage : IHasBenefits, IHasRate
    {
        public string Benefits()
        {
            return "Free daily coffe at Starbucks for a month";
        }

        public decimal GetHourlyWage()
        {
            return decimal.Multiply(100, GetRate());
        }

        public decimal GetRate()
        {
           return 3.5M;
        }
    }
}
