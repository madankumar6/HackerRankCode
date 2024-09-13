namespace _30DaysOfCode
{
    internal class Day1 : DayProgram
    {
        public override void RunProgram()
        {
            // Declare second integer, double, and String variables.
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";

            // Read and save an integer, double, and String to your variables.
            i = i + int.Parse(Console.ReadLine());
            d = d + double.Parse(Console.ReadLine());
            s = s + Console.ReadLine();
            // Print the sum of both integer variables on a new line.
            Console.WriteLine(i);
            // Print the sum of the double variables on a new line.
            Console.WriteLine(d.ToString("0.0"));
            // Concatenate and print the String variables on a new line
            // The 's' variable above should be printed first.
            Console.WriteLine(s);
        }
    }
}
