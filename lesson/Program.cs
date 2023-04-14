using System;

namespace lesson
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Book b1 = new Book();
            Book b2 = new Book("Толстой Л.Н.", "Война и мир", "Наука и жизнь", 1234, 2013, 101, true);
            Book b3 = new Book("Лермонтов М.Ю.", "Мцыри");

            Magazine mag1 = new Magazine("О природе", 5, "Земля и мы", 2014, 1235, true);

            Item[] itmas = new Item[4];
            itmas[0] = b1;
            itmas[1] = b2;
            itmas[2] = b3;
            itmas[3] = mag1;

            Array.Sort(itmas);

            b1.SetBook("Пушкин А.С.", "Капитанская дочка", "Вильямс", 123, 2012);
            // Book.SetPrice(12);
            b1.Show();
            Console.WriteLine("\n Итоговая стоимость аренды: {0} р.", b1.PriceBook(3));

            b2.TakeItem();
            b2.Show();

            b3.Show();

            mag1.Show();

            Console.WriteLine("\nТестирование полиморфизма");
            Item it;
            it = b2;
            it.TakeItem();
            it.Return();
            it.Show();

            it = mag1;
            it.TakeItem();
            it.Return();
            it.Show();

            mag1.Show();
            mag1.IfSubs = true;
            mag1.Subs();

            Console.WriteLine("\nСортировка по инвентарному номеру");
            foreach (Item x in itmas)
            {
                x.Show();
            }

        }
    }
}