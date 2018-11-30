using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Guard: NameGenerator, IWork
    {
        private static Random random = new Random();
        public Guard(string name, string surName, int price) : base(name, surName, price) { }
        public void Work()
        {
            Console.Write("Охранник " + Name + ' ' + SurName + ' ');
            switch (random.Next(0, 4))
            {
                case 0: Console.WriteLine("осуществляет обход периметра"); break;
                case 1: Console.WriteLine("бдит"); break;
                case 2: Console.WriteLine("уснул на рабочем месте"); break;
                case 3: Console.WriteLine("не явился на работу"); IsHooky = true; break;
            }
        }
    }
}
