using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson
{
    internal class Book : Item
    {
        private string author;
        private string title;
        private string publisher;
        private int pages;
        private int year;
        private bool returnSrok;

        private static double price = 9;

        static Book()
        {
            price = 10;
        }

        public Book(string author, string title, string publisher, int pages, int year, long invNumber, bool isTaken) : base(invNumber, isTaken)
        {
            this.author = author;
            this.title = title;
            this.publisher = publisher;
            this.pages = pages;
            this.year = year;
        }

        public Book(string author, string title, string publisher, int pages, int year)
        {
            this.author = author;
            this.title = title;
            this.publisher = publisher;
            this.pages = pages;
            this.year = year;
        }

        public Book(string author, string title)
        {
            this.author = author;
            this.title = title;
        }

        public Book()
        {

        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Publisher
        {
            get { return publisher; }
            set { publisher = value; }
        }

        public int Pages
        {
            get { return pages; }
            set { pages = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public void ReturnSrok()
        {
            returnSrok = true;
        }

        public override void Return()
        {
            if (returnSrok == true) taken = true;
            else taken = false;
        }

        public void SetBook(string author, string title, string publisher, int pages, int year)
        {
            this.author = author;
            this.title = title;
            this.publisher = publisher;
            this.pages = pages;
            this.year = year;
        }

        public static void SetPrice(double price)
        {
            Book.price = price;
        }

        public override void Show()
        {
            Console.WriteLine("\nКнига:\n Автор: {0}\n Название: {1}\n Год издания: {2}\n Издательство: {3}\n {4} стр.\n Стоимость аренды: {5} р.", author, title, year, publisher, pages, Book.price);
            base.Show();
        }

        public double PriceBook(int s)
        {
            double cost = s * price;
            return cost;
        }
    }
}
