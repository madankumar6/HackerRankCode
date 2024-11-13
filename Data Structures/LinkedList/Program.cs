using System.Collections.Generic;

namespace LinkedList
{
    public abstract class LinkedListProgram
    {
        public abstract void RunProgram();
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int choice, data, position, x;

            SinglyLinkedList list = new SinglyLinkedList();

            //list.CreateList();

            while (true)
            {
                Console.WriteLine("1.Create Linked List");
                Console.WriteLine("2.Print the Elements of a Linked List");
                Console.WriteLine("3.Insert a node at the head of a linked list");
                Console.WriteLine("4.Insert a node at the end of the list");
                Console.WriteLine("5.Delete the node");
                Console.WriteLine("6.Print in reverse");
                Console.WriteLine("7.Reverse a list");
                Console.WriteLine("8.Insert a Node at specific position in a list");
                Console.WriteLine("9.Compare two lists");
                Console.WriteLine("10.Get node value");
                Console.WriteLine("11.Delete duplicate node from the list");
                Console.WriteLine("12.Cycle detection");
                Console.WriteLine("13.Find Merge Point of Two Lists");

                Console.WriteLine("99.Quit");

                Console.Write("Enter your choice : ");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 99)
                    break;

                switch (choice)
                {
                    case 1:
                        list.CreateList();
                        break;
                    case 2:
                        //https://www.hackerrank.com/challenges/print-the-elements-of-a-linked-list/problem?isFullScreen=true
                        list.PrintLinkedList();
                        break;
                    case 3:
                        //https://www.hackerrank.com/challenges/insert-a-node-at-the-head-of-a-linked-list/problem?isFullScreen=true
                        Console.Write("Enter the element to be inserted at beginning : ");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.Head = list.InsertInBeginning(list.Head, data);
                        break;
                    case 4:
                        //https://www.hackerrank.com/challenges/insert-a-node-at-the-tail-of-a-linked-list/problem?isFullScreen=true
                        Console.Write("Enter the element to be inserted at the end: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.Head = list.InsertNodeAtTail(list.Head, data);
                        break;
                    case 5:
                        //https://www.hackerrank.com/challenges/delete-a-node-from-a-linked-list/problem?isFullScreen=true
                        Console.Write("Enter the position of the node to be deleted: ");
                        position = Convert.ToInt32(Console.ReadLine());
                        list.Head = list.DeleteANodeAtPosition(list.Head, position);
                        break;
                    case 6:
                        //https://www.hackerrank.com/challenges/print-the-elements-of-a-linked-list-in-reverse/problem?isFullScreen=true
                        Console.Write("Reversal of the list: ");
                        list.DiplayListInReverse(list.Head);
                        break;
                    case 7  :
                        //https://www.hackerrank.com/challenges/reverse-a-linked-list/problem?isFullScreen=true
                        Console.Write("Reversal of the list: ");
                        list.Head = list.ReverseList(list.Head);
                        break;
                    case 8:
                        //https://www.hackerrank.com/challenges/insert-a-node-at-a-specific-position-in-a-linked-list/problem?isFullScreen=true
                        Console.Write("Enter the position of the node: ");
                        position = Convert.ToInt32(Console.ReadLine());
                        Console.Write($"Enter the element to be inserted : ");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.Head = list.InsertANodeAtPosition(list.Head, data, position);
                        break;
                    case 9:
                        //https://www.hackerrank.com/challenges/compare-two-linked-lists/problem?isFullScreen=true
                        list.CompareLists();
                        break;
                    case 10:
                        //https://www.hackerrank.com/challenges/get-the-value-of-the-node-at-a-specific-position-from-the-tail/problem?isFullScreen=true
                        Console.Write("Enter the position of the node from tail: ");
                        position = Convert.ToInt32(Console.ReadLine());
                        list.Head = list.GetNodeValueFromTail(list.Head, position);
                        break;
                    case 11:
                        //https://www.hackerrank.com/challenges/get-the-value-of-the-node-at-a-specific-position-from-the-tail/problem?isFullScreen=true
                        list.Head = list.DeleteDuplicateNodes(list.Head);
                        break;
                    case 12:
                        //https://www.hackerrank.com/challenges/detect-whether-a-linked-list-contains-a-cycle/problem?isFullScreen=true
                        var hasCycle = list.HasCycle(list.Head);
                        Console.WriteLine("This list has a cycle : " + hasCycle);
                        break;
                    case 13:
                        //https://www.hackerrank.com/challenges/find-the-merge-point-of-two-joined-linked-lists/problem?isFullScreen=true
                        var mergePointValue = list.FindMergePoint();
                        break;
                    default:
                        Console.WriteLine("Wrong choice");
                        break;
                }
                Console.WriteLine();
            }

            Console.WriteLine("Exiting");
        }
    }
}
