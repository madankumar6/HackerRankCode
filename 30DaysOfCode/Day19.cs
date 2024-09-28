namespace _30DaysOfCode
{
    public interface AdvancedArithmetic
    {
        int divisorSum(int n);
    }

    public class Calculator : AdvancedArithmetic
    {
        public int divisorSum(int n)
        {
            List<int> divisibleNumbers = new List<int>();
            int divisibleNumbersSum = 0;

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    divisibleNumbers.Add(i);
                }
            }

            divisibleNumbersSum = divisibleNumbers.Sum();

            return divisibleNumbersSum;
        }
    }

    internal class Day19 : DayProgram
    {
        public override void RunProgram()
        {
            int n = Int32.Parse(Console.ReadLine());
            AdvancedArithmetic myCalculator = new Calculator();
            int sum = myCalculator.divisorSum(n);
            Console.WriteLine("I implemented: AdvancedArithmetic\n" + sum);
        }
    }
}
