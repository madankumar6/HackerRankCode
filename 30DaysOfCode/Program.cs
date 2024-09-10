
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
            Console.WriteLine("Enter the number of the day of the program you want to run (1-30, strictly!)!");
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
                10 => new Day10(),
                _ => throw new InvalidDataException("This day doesn't exist in this contest")
            };
        }
    }
}
