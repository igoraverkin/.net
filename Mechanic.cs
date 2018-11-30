using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Mechanic: NameGenerator, IWork
    {
        private static Random random = new Random();
        public Mechanic(string name, string surName, int price) : base(name, surName, price) { }
        public void Work()
        {
            Console.Write("Механик " + Name + ' ' + SurName + ' ');
            switch (random.Next(0, 2))
            {
                case 0: Console.WriteLine("проверяет оборудование "); break;
                case 1: Console.WriteLine("не вышел на работу"); IsHooky = true; break;
            }
        }
    }
}
