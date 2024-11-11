
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

        internal SinglyLinkedListNode DeleteANodeAtPosition(SinglyLinkedListNode head, int position)
        {
            if (head == null)
            {
                return null;
            }

            var node = head;
            SinglyLinkedListNode prev = null;
            int currentPosition = 0;

            while (node != null)
            {
                if (currentPosition == position)
                {
                    break;
                }
                prev = node;
                node = node.Next;
                currentPosition++;
            }

            if (node == null)
            {
                Console.Write($"Node at position {position} not found");
            }
            else if (prev == null)
            {
                head = node.Next;
            }
            else
            {
                prev.Next = node.Next;
            }

            return head;
        }

        internal SinglyLinkedListNode InsertInBeginning(SinglyLinkedListNode head, int data)
        {
            SinglyLinkedListNode node = new SinglyLinkedListNode(data);

            if (head == null)
            {
                head = node;
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

        internal SinglyLinkedListNode ReverseList(SinglyLinkedListNode head)
        {
            // The following takes O(n) Time and O(n) Space using the stack approach
            //Stack<int> listData = new Stack<int>();

            //var node = head;

            //while(node != null) {
            //    listData.Push(node.Data);
            //    node = node.Next;
            //}

            //node = head;
            //while(node != null) {
            //    node.Data =  listData.Pop();
            //    node = node.Next;
            //}

            //return head;

            SinglyLinkedListNode start = head;
            SinglyLinkedListNode prev = null, next = null;
            var node = head;

            while (node != null)
            {
                next = node.Next;
                node.Next = prev;
                prev = node;
                node = next;
            }

            head = prev;
            return head;
        }

        internal void DiplayListInReverse(SinglyLinkedListNode head)
        {
            if (head == null)
            {
                return;
            }

            DiplayListInReverse(head.Next);

            Console.WriteLine(head.Data);
        }

        internal SinglyLinkedListNode InsertANodeAtPosition(SinglyLinkedListNode head, int data, int position)
        {
            if (head == null)
            {
                return null;
            }

            var node = head;
            SinglyLinkedListNode prev = null;
            int currentPosition = 0;

            while (node != null)
            {
                if (currentPosition == position)
                {
                    break;
                }
                prev = node;
                node = node.Next;
                currentPosition++;
            }

            var newNode = new SinglyLinkedListNode(data);

            if (node == null)
            {
                Console.Write($"Node at position {position} not found");
            }
            else if (prev == null)
            {
                newNode.Next = node;
                head = newNode;
            }
            else
            {
                newNode.Next = node;
                prev.Next = newNode;
            }

            return head;
        }

        internal void CompareLists()
        {
            SinglyLinkedList list1 = new SinglyLinkedList();
            SinglyLinkedList list2 = new SinglyLinkedList();

            list1.CreateList();
            list2.CreateList();

            bool areListsSame = CompareLists(list1.Head, list2.Head);
            Console.WriteLine("Are the lists same : " + areListsSame);
        }

        private bool CompareLists(SinglyLinkedListNode head1, SinglyLinkedListNode head2)
        {
            var areListsSame = true;

            SinglyLinkedListNode node1 = head1;
            SinglyLinkedListNode node2 = head2;

            while (node1 != null && node2 != null)
            {
                if (node1.Data != node2.Data)
                {
                    areListsSame = false;
                    break;
                }

                node1 = node1.Next;
                node2 = node2.Next;
            }

            if (areListsSame && (node1 != null || node2 != null))
            {
                areListsSame = false;
            }

            return areListsSame;
        }
    }
}
