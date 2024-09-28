namespace _30DaysOfCode
{
    internal class Day17 : DayProgram
    {
        class Calculator
        {
            public int Power(int n, int p)
            {
                if (n < 0 || p < 0)
                {
                    throw new ArgumentException("n and p should be non-negative");
                }

                return (int)Math.Pow(n, p);
            }
        }

        public override void RunProgram()
        {
            Calculator myCalculator = new Calculator();
            int T = Int32.Parse(Console.ReadLine());
            
            while (T-- > 0)
            {
                string[] num = Console.ReadLine().Split();
                int n = int.Parse(num[0]);
                int p = int.Parse(num[1]);
                try
                {
                    int ans = myCalculator.Power(n, p);
                    Console.WriteLine(ans);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);

                }
            }
        }
    }
}
