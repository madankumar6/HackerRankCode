namespace _30DaysOfCode
{
    internal class Day10 : DayProgram
    {
        public override void RunProgram()
        {
            int number = Convert.ToInt32(Console.ReadLine().Trim());
            Stack<int> binaryStack = new Stack<int>();
            int consecutive1s = 0;
            int maxConsecutive1s = 0;

            while (number > 0)
            {
                var reminder = number % 2;
                number = number / 2;
                binaryStack.Push(reminder);
            }

            while (binaryStack.TryPop(out int n))
            {
                if (n == 1)
                {
                    consecutive1s++;
                }
                else
                {
                    if (consecutive1s > maxConsecutive1s)
                    {
                        maxConsecutive1s = consecutive1s;
                    }
                    consecutive1s = 0;
                }
            }

            if (consecutive1s > maxConsecutive1s)
            {
                maxConsecutive1s = consecutive1s;
            }

            Console.WriteLine(maxConsecutive1s);
        }
    }
}
