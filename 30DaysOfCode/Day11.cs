namespace _30DaysOfCode
{
    internal class Day11 : DayProgram
    {
        public override void RunProgram()
        {
            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < 6; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            int maxHourGlass = int.MinValue;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    var topRowSum = arr[i][j] + arr[i][j+1] + arr[i][j+2];
                    var midRowSum = arr[i+1][j+1];
                    var bottomRowSum = arr[i+2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];
                    var hourglassSum = topRowSum + midRowSum + bottomRowSum;

                    if (hourglassSum > maxHourGlass)
                    {
                        maxHourGlass = hourglassSum;
                    }
                }
            }

            Console.WriteLine(maxHourGlass);
        }
    }
}
