namespace _30DaysOfCode
{
    internal class Day8 : DayProgram
    {
        public override void RunProgram()
        {
            int numberOfContacts = Convert.ToInt32(Console.ReadLine().Trim());
            var contacts = new Dictionary<string, long?>(numberOfContacts);
            List<string> searchKeys = new List<string>(numberOfContacts);

            for (int i = 0; i < numberOfContacts; i++)
            {
                var inputs = Console.ReadLine().Trim().Split(" ");

                if (long.TryParse(inputs[1], out long number))
                {
                    if (!contacts.ContainsKey(inputs[0]))
                    {
                        contacts.Add(inputs[0], number);
                    }
                    else
                    {
                        contacts[inputs[0]] = number;
                    }
                }
            }

            for (int i = 0; i < numberOfContacts; i++)
            {
                var key = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(key))
                {
                    searchKeys.Add(key);
                }
            }

            for (int i = 0; i < searchKeys.Count; i++)
            {
                if (contacts.TryGetValue(searchKeys[i], out long? number))
                {
                    Console.WriteLine($"{searchKeys[i]}={number}");
                }
                else
                {
                    Console.WriteLine("Not found");
                }
            }
        }
    }
}
