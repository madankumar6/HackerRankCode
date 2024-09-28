namespace _30DaysOfCode
{
    class Difference
    {
        private int[] elements;
        public int maximumDifference;

        // Add your code here
        public Difference(int[] input)
        {
            this.elements = input;
        }

        public void ComputeDifference()
        {
            var list = elements.ToList();
            list.Sort();
            this.maximumDifference = Math.Abs(list[list.Count-1] - list[0]);
        }

    } // End of Difference Class

    internal class Day14 : DayProgram
    {
        public override void RunProgram()
        {
            Convert.ToInt32(Console.ReadLine());

            int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            Difference d = new Difference(a);

            d.ComputeDifference();
            Console.Write(d.maximumDifference);
        }
    }
}
