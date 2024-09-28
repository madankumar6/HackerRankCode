namespace _30DaysOfCode
{
    internal class Day15 : DayProgram
    {
        internal class Node
        {
            public int data;
            public Node next;
            public Node(int d)
            {
                data = d;
                next = null;
            }

        }



        public static void Display(Node head)
        {
            Node start = head;
            while (start != null)
            {
                Console.Write(start.data + " ");
                start = start.next;
            }
        }

        public static Node Insert(Node head, int inputData)
        {
            Node temp = new Node(inputData);

            if (head == null)
            {
                head = temp;
                return head;
            }

            Node node = head;
            while (node.next != null)
            {
                node = node.next;
            }

            node.next = temp;

            return head;
        }

        public override void RunProgram()
        {
            Node head = null;

            int T = Int32.Parse(Console.ReadLine());
            
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                head = Insert(head, data);
            }

            Display(head);
        }
    }
}
