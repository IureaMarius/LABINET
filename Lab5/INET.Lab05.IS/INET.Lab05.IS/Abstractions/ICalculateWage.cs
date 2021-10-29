namespace INET.Lab05.IS.Abstractions
{
    interface ICalculateWage
    {
        public decimal GetRate();

        public float GetHourlyWage();

        public decimal GetMonthlyWage();

        public decimal GetBonus();

        public string Benefits();
    }
}
