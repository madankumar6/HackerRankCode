namespace _30DaysOfCode
{
    internal class Day16 : DayProgram
    {
        public override void RunProgram()
        {
            string S = Console.ReadLine();

            try
            {
                int number = int.Parse(S);
                Console.WriteLine(number);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Bad String");
            }

            //if (int.TryParse(S, out int number))
            //{
            //    Console.WriteLine(number);
            //}
            //else 
            //{
            //    Console.WriteLine("Bad String"); 
            //}
        }
    }
}
