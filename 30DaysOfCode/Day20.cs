namespace _30DaysOfCode
{
    internal class Day20 : DayProgram
    {
        public override void RunProgram()
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();
            int numberOfSwaps = 0;

            for (int i = 0; i < a.Count; i++)
            {
                for (int j = i+1; j < a.Count; j++)
                {
                    if (a[i] > a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                        numberOfSwaps++;
                    }
                }
            }

            Console.WriteLine($"Array is sorted in {numberOfSwaps} swaps.");
            Console.WriteLine($"First Element: {a[0]}");
            Console.WriteLine($"Last Element: {a[a.Count - 1]}");
        }
    }
}
