
namespace _30DaysOfCode
{
    public abstract class DayProgram
    {
        public abstract void RunProgram();
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of the day of the program you want to run (0-29, strictly!)!");
            int day = int.Parse(Console.ReadLine() ?? "1"); 

            DayProgram program;

            try
            {
                program = GetProgramClass(day); // new Day10();
                program.RunProgram();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); return;
            }
        }

        private static DayProgram GetProgramClass(int day)
        {
            return day switch
            {
                0 => new Day0(),
                1 => new Day1(),
                2 => new Day2(),
                3 => new Day3(),
                4 => new Day4(),
                5 => new Day5(),
                6 => new Day6(),
                7 => new Day7(),
                8 => new Day8(),
                9 => new Day9(),
                10 => new Day10(),
                11 => new Day11(),
                12 => new Day12(),
                13 => new Day13(),
                14 => new Day14(),
                15 => new Day15(),
                16 => new Day16(),
                17 => new Day17(),
                18 => new Day18(),
                19 => new Day19(),
                20 => new Day20(),
                21 => new Day21(),
                22 => new Day22(),
                _ => throw new InvalidDataException("This day doesn't exist in this contest")
            };
        }
    }
}
