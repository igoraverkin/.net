using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Geologist: NameGenerator, IWork
    {
        private static Random random = new Random();
        public Geologist(string name, string surName, int price) : base(name, surName, price) { }
        public void Work()
        {
            Console.Write("Геолог " + Name + ' ' + SurName + ' ');
            switch (random.Next(0, 5))
            {
                case 0: Console.WriteLine("осматривает местность"); break;
                case 1: Console.WriteLine("устанавливает флаги"); break;
                case 2: Console.WriteLine("документирует работу"); break;
                case 3: Console.WriteLine("производит проверку"); break;
                case 4: Console.WriteLine("не явился на работу");  IsHooky = true; break;
            }
        }
    }
}
