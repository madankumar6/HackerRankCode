namespace _30DaysOfCode
{
    class Result
    {

        /*
         * Complete the 'factorial' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts INTEGER n as parameter.
         */

        public static int factorial(int n)
        {
            if (n == 1)
            {
                return 1;
            }

            return  n * factorial(n - 1);
        }

    }

    internal class Day9 : DayProgram
    {
        public override void RunProgram()
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            int result = Result.factorial(n);
            Console.WriteLine(result);
        }
    }
}
