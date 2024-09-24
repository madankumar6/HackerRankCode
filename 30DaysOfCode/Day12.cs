namespace _30DaysOfCode
{

    class PersonClass
    {
        protected string firstName;
        protected string lastName;
        protected int id;

        public PersonClass() { }

        public PersonClass(string firstName, string lastName, int identification)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = identification;
        }
        public void PrintPerson()
        {
            Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
        }
    }

    class Student : PersonClass
    {
        private int[] testScores;

        /*	
        *   Class Constructor
        *   
        *   Parameters: 
        *   firstName - A string denoting the Person's first name.
        *   lastName - A string denoting the Person's last name.
        *   id - An integer denoting the Person's ID number.
        *   scores - An array of integers denoting the Person's test scores.
        */
        // Write your constructor here

        public Student(string firstName, string lastName, int identification, int[] scores) : base(firstName, lastName, identification)
        {
            this.testScores = scores;
        }

        /*	
        *   Method Name: Calculate
        *   Return: A character denoting the grade.
        */
        // Write your method here
        public string Calculate()
        {
            int average = testScores.Sum() / testScores.Length;

            var grade = average switch
            {
                (>= 90) and (<= 100) => "O",
                (>= 80) and (<= 89) => "E",
                (>= 70) and (<= 79) => "A",
                (>= 55) and (<= 69) => "P",
                (>= 40) and (<= 54) => "D",
                (<= 39) => "T",
            };

            return grade;
        }
    }

    internal class Day12 : DayProgram
    {
        public override void RunProgram()
        {
            string[] inputs = Console.ReadLine().Split();
            string firstName = inputs[0];
            string lastName = inputs[1];
            int id = Convert.ToInt32(inputs[2]);
            int numScores = Convert.ToInt32(Console.ReadLine());
            inputs = Console.ReadLine().Split();
            int[] scores = new int[numScores];
            for (int i = 0; i < numScores; i++)
            {
                scores[i] = Convert.ToInt32(inputs[i]);
            }

            Student s = new Student(firstName, lastName, id, scores);
            s.PrintPerson();
            Console.WriteLine("Grade: " + s.Calculate() + "\n");
        }
    }
}
