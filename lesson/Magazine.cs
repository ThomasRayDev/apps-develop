using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson
{
    internal class Magazine : Item, IPubs
    {
        private string volume;
        private int number;
        private string title;
        private int year;

        public Magazine() { }

        public Magazine(string volume, int number, string title, int year, int invNumber, bool isTaken) : base(invNumber, isTaken)
        {
            this.volume = volume;
            this.number = number;
            this.title = title;
            this.year = year;
        }

        public override void Show()
        {
            Console.WriteLine("\nЖурнал:\n Том: {0}\n Номер: {1}\n Название: {2}\n Год выпуска: {3}", this.volume, this.number, this.title, this.year);
            base.Show();
        }

        public override void Return()
        {
            taken = true;
        }

        public bool IfSubs { get; set; }

        public void Subs()
        {
            Console.WriteLine("Подписка на журнал \"{0}\": {1}", title, IfSubs);
        }
    }
}
