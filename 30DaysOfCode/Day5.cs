namespace _30DaysOfCode
{
    internal class Day5 : DayProgram
    {
        public override void RunProgram()
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{n} x {i} = {i*n}");
            }
        }
    }
}
