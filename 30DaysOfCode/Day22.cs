using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30DaysOfCode
{
    internal class Day22 : DayProgram
    {
        class Node
        {
            public Node left, right;
            public int data;
            public Node(int data)
            {
                this.data = data;
                left = right = null;
            }
        }

        static int GetHeight(Node root)
        {
            //Write your code here
            int height = 0;

            if (root == null)
            {
                return -1;
            }

            return height;
        }

        static Node Insert(Node root, int data)
        {
            if (root == null)
            {
                return new Node(data);
            }
            else
            {
                Node cur;
                if (data <= root.data)
                {
                    cur = Insert(root.left, data);
                    root.left = cur;
                }
                else
                {
                    cur = Insert(root.right, data);
                    root.right = cur;
                }
                return root;
            }
        }

        public override void RunProgram()
        {
            Node root = null;
            int T = Int32.Parse(Console.ReadLine());
            
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                root = Insert(root, data);
            }

            int height = GetHeight(root);
            Console.WriteLine(height);
        }
    }
}
