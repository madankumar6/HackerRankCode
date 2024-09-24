using System.Text;

namespace _30DaysOfCode
{
    internal class Day6 : DayProgram
    {
        public override void RunProgram()
        {
            int inputs = Convert.ToInt32(Console.ReadLine().Trim());
            List<string> texts = new List<string>();
            
            for (int i = 0; i < inputs; i++)
            {
                texts.Add(Console.ReadLine().Trim());
            }

            for (int i = 0; i < inputs; i++)
            {
                string text = texts[i];
                StringBuilder oddPart = new StringBuilder();
                StringBuilder evenPart = new StringBuilder();

                for (int j = 0; j < text.Length; j++)
                {
                    if (j % 2 != 0)
                    {
                        oddPart.Append(text[j]);
                    }
                    else
                    {
                        evenPart.Append(text[j]);
                    }
                }

                Console.WriteLine($"{evenPart.ToString()} {oddPart.ToString()}");
            }

            Console.ReadLine();
        }
    }
}
