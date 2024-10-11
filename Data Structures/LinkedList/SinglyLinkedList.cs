
namespace LinkedList
{
    public class SinglyLinkedListNode
    {
        public int Data;
        public SinglyLinkedListNode Next;

        public SinglyLinkedListNode(int nodeData)
        {
            this.Data = nodeData;
            this.Next = null;
        }
    }

    public class SinglyLinkedList
    {
        public SinglyLinkedListNode Head;
        public SinglyLinkedListNode Tail;

        public SinglyLinkedList()
        {
            this.Head = null;
            this.Tail = null;
        }

        public void InsertNode(int nodeData)
        {
            SinglyLinkedListNode node = new SinglyLinkedListNode(nodeData);

            if (this.Head == null)
            {
                this.Head = node;
            }
            else
            {
                this.Tail.Next = node;
            }

            this.Tail = node;
        }

        public void PrintLinkedList()
        {
            if (this.Head == null)
            {
                return;
            }

            var node = Head;

            while (node != null)
            {
                Console.Write(node.Data + " ");
                node = node.Next;
            }

        }

        internal void CreateList()
        {
            Console.Write("Enter the number of nodes : ");
            int nodesCount = Convert.ToInt32(Console.ReadLine());

            if (nodesCount == 0)
            {
                return;
            }

            for (int i = 1; i <= nodesCount; i++)
            {
                Console.Write("Enter the element to be inserted : ");
                int data = Convert.ToInt32(Console.ReadLine());
                InsertNode(data);
            }
        }

        internal SinglyLinkedListNode InsertInBeginning(SinglyLinkedListNode head, int data)
        {
            SinglyLinkedListNode node = new SinglyLinkedListNode(data);

            if (head == null)
            {
                head = node;
                Tail = node;
            }
            else
            {
                node.Next = head;
                head = node;
            }

            return node;
        }

        internal SinglyLinkedListNode InsertNodeAtTail(SinglyLinkedListNode head, int data)
        {
            // We don't use the tail node, we must use the head for insertion at the end of the list

            SinglyLinkedListNode node = new SinglyLinkedListNode(data);

            if (head == null)
            {
                head = node;
            }
            else
            {
                SinglyLinkedListNode temp = head;

                while (temp.Next != null)
                {
                    temp = temp.Next;
                }

                temp.Next = node;
            }

            return head;
        }
    }
}
