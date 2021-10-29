using INET.Lab05.IS.Abstractions;

namespace INET.Lab05.IS
{
    public class CalculateVolunteerWage : ICalculateWage
    {
        public decimal GetBonus()
        {
            throw new System.NotImplementedException();
        }

        public float GetHourlyWage()
        {
            throw new System.NotImplementedException();
        }

        public decimal GetMonthlyWage()
        {
            throw new System.NotImplementedException();
        }

        public decimal GetRate()
        {
            throw new System.NotImplementedException();
        }

        public string Benefits()
        {
            return "Tickets to Avatar 2 premiere";
        }

        string ICalculateWage.Benefits()
        {
            throw new System.NotImplementedException();
        }
    }
}
