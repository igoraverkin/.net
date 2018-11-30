using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Personal_Department : IWorkWithPersonal
    {
        private static Random random = new Random();
        string[] names = new string[] { "Дмитрий", "Иван", "Олег", "Валерий", "Филимон", "Себастьян", "Геннадий","Акакий", "Арчил","Михаил" };
        string[] surNames = new string[] { "Воложев", "Карасин", "Сальников", "Курст", "Сапожников", "Ворожцов", "Карчава","Кузнецов","Шарапов" };
        int[] prices = new int[] { 35000, 20000, 10000, 8000 };
        public void Work(ref List<Geologist> geologists, ref List<Mechanic> mechanics, ref List<Worker> workers,
            ref List<Guard> guards, ref int budget, ref int projectNumber)
        {
            Console.Write("Отдел кадров:  ");
            
            if (projectNumber == 1)
            {
                Console.WriteLine("Нанимаем геологов, механиков, рабочих и охрану");
                /* GEOLOGISTS */
                for (int i = 0; i < 3; i++) { geologists.Add(new Geologist(names[random.Next(0, 10)], surNames[random.Next(0,9)],prices[0])); }
                /* MECHANICS */
                for (int i = 0; i < 2; i++) { mechanics.Add(new Mechanic(names[random.Next(0, 10)], surNames[random.Next(0, 9)], prices[1])); }
                /* WORKERS */
                for (int i = 0; i < 9; i++) { workers.Add(new Worker(names[random.Next(0, 10)], surNames[random.Next(0, 9)], prices[2])); }
                /* GUARDS */
                for (int i = 0; i < 3; i++) { guards.Add(new Guard(names[random.Next(0, 10)], surNames[random.Next(0,9)], prices[3])); }
            }
            if (projectNumber == 2)
            {
                Console.WriteLine("Нанимаем геологов, механиков, рабочих и охрану");
                /* GEOLOGISTS */
                for (int i = 0; i < 2; i++) { geologists.Add(new Geologist(names[random.Next(0, 10)], surNames[random.Next(0, 9)], prices[0])); }
                /* MECHANICS */
                for (int i = 0; i < 1; i++) { mechanics.Add(new Mechanic(names[random.Next(0, 10)], surNames[random.Next(0, 9)], prices[1])); }
                /* WORKERS */
                for (int i = 0; i < 6; i++) { workers.Add(new Worker(names[random.Next(0, 10)], surNames[random.Next(0, 9)], prices[2])); }
                /* GUARDS */
                for (int i = 0; i < 2; i++) { guards.Add(new Guard(names[random.Next(0, 10)], surNames[random.Next(0, 9)], prices[3])); }
            }
            if (projectNumber == 3)
            {
                Console.WriteLine("Нанимаем геологов, механиков, рабочих и охрану");
                /* GEOLOGISTS */
                for (int i = 0; i < 1; i++) { geologists.Add(new Geologist(names[random.Next(0, 10)], surNames[random.Next(0, 9)], prices[0])); }
                /* WORKERS */
                for (int i = 0; i < 3; i++) { workers.Add(new Worker(names[random.Next(0, 10)], surNames[random.Next(0, 9)], prices[2])); }
                /* GUARDS */
                for (int i = 0; i < 1; i++) { guards.Add(new Guard(names[random.Next(0, 10)], surNames[random.Next(0, 9)], prices[3])); }
            }
        }
    }
}
