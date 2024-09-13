namespace _30DaysOfCode
{
    internal class Day2 : DayProgram
    {
        public override void RunProgram()
        {
            double meal_cost = Convert.ToDouble(Console.ReadLine().Trim());

            int tip_percent = Convert.ToInt32(Console.ReadLine().Trim());

            int tax_percent = Convert.ToInt32(Console.ReadLine().Trim());

            Solve(meal_cost, tip_percent, tax_percent);
        }

        private void Solve(double meal_cost, int tip_percent, int tax_percent)
        {
            var tip = (meal_cost / 100) * tip_percent;
            var tax = ((double)tax_percent / 100) * meal_cost;
            var totalCost = meal_cost + tip + tax;

            Console.WriteLine(Math.Round(totalCost));
        }
    }
}
