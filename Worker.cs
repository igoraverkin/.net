using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Worker : NameGenerator, IWork
    {
        private static Random random = new Random();
        public Worker(string name, string surName, int price) : base(name, surName, price) { }
        public override int Price { get => base.Price; set => base.Price = value; }
        public void Work()
        {
            Console.Write("Рабочий " + Name + ' ' + SurName + ' ');
            switch (random.Next(0,4))
            { 
                case 0: Console.WriteLine("ставит оборудование"); break;
                case 1: Console.WriteLine("производит замеры"); break;
                case 2: Console.WriteLine("ведёт машину"); break;
                case 3: Console.WriteLine("не вышел на работу"); IsHooky = true; break;
            }
        }
    }
}
