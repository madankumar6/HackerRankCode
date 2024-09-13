namespace _30DaysOfCode
{
    internal class Day3 : DayProgram
    {
        public override void RunProgram()
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            var isOdd = n % 2 != 0;

            if (isOdd)
            {
                Console.WriteLine("Weird");
            }
            else
            {
                if (n >= 2 && n <= 5)
                {
                    Console.WriteLine("Not Weird");
                }
                else if (n >= 6 && n <= 20)
                {
                    Console.WriteLine("Weird");
                }
                else
                {
                    Console.WriteLine("Not Weird");
                }
            }

        }
    }
}
