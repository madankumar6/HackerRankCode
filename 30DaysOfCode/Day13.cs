using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30DaysOfCode
{
    public abstract class Book
    {

        protected string title;
        protected string author;

        public Book(string t, string a)
        {
            title = t;
            author = a;
        }

        public abstract void display();
    }

    public class MyBook : Book
    {
        protected int price;

        public MyBook(string title, string author, int price) : base(title, author)
        {
            this.price = price;
        }

        public override void display()
        {
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Author: {author}");
            Console.WriteLine($"Price: {price}");
        }
    }

    public class Day13 : DayProgram
    {
        public override void RunProgram()
        {
            string title = Console.ReadLine();
            string author = Console.ReadLine();
            int price = Int32.Parse(Console.ReadLine());
            Book new_novel = new MyBook(title, author, price);
            new_novel.display();
        }
    }
}
