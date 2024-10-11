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

                Console.WriteLine("19.Quit");

                Console.Write("Enter your choice : ");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 19)
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
                    //case 5:
                    //    Console.Write("Enter the element to be inserted at the end: ");
                    //    data = Convert.ToInt32(Console.ReadLine());
                    //    list.InsertAtEnd(data);
                    //    break;
                    //case 6:
                    //    Console.Write("Enter the element to be inserted : ");
                    //    data = Convert.ToInt32(Console.ReadLine());
                    //    Console.Write("Enter the element after which to insert : ");
                    //    x = Convert.ToInt32(Console.ReadLine());
                    //    list.InsertAfter(x, data);
                    //    break;
                    //case 7:
                    //    Console.Write("Enter the element to be inserted : ");
                    //    data = Convert.ToInt32(Console.ReadLine());
                    //    Console.Write("Enter the element before which to insert : ");
                    //    x = Convert.ToInt32(Console.ReadLine());
                    //    list.InsertBefore(x, data);
                    //    break;
                    //case 8:
                    //    Console.Write("Enter the element to be inserted : ");
                    //    data = Convert.ToInt32(Console.ReadLine());
                    //    Console.Write("Enter the position at which to insert : ");
                    //    position = Convert.ToInt32(Console.ReadLine());
                    //    list.InsertAtPosition(data, position);
                    //    break;
                    //case 9:
                    //    list.DeleteFirstNode();
                    //    break;
                    //case 10:
                    //    list.DeleteLastNode();
                    //    break;
                    //case 11:
                    //    Console.Write("Enter the element to be deleted : ");
                    //    data = Convert.ToInt32(Console.ReadLine());
                    //    list.DeleteNode(data);
                    //    break;
                    //case 12:
                    //    list.ReverseList();
                    //    break;
                    //case 13:
                    //    list.BubbleSortExData();
                    //    break;

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
