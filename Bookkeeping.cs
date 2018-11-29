using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Bookkeeping : IWorkWithPersonal
    {
        private static Random random = new Random();
        public void Work(ref List<Geologist> geologists, ref List<Mechanic> mechanics,
            ref List<Worker> workers, ref List<Guard> guards, ref int budget, ref int projectNumber)
        {
            Console.WriteLine("Бухгалтерия: ");
            Console.WriteLine("-----------------------");
            Console.WriteLine("Выплата зарплат рабочим: ");
            foreach (Geologist employee in geologists)
            {
                if (employee.IsHooky == true) Console.WriteLine(employee.Name + ' ' + employee.SurName + " ПОСМЕЛ НЕ ЯВИТЬСЯ НА РАБОТУ!!!");
                else
                {
                    budget -= 35000;
                    Console.WriteLine(employee.Name + ' ' + employee.SurName + ": " + "35000");
                }
            }
            foreach (Mechanic employee in mechanics)
            {
                if (employee.IsHooky == true) Console.WriteLine(employee.Name + ' ' + employee.SurName + " ПОСМЕЛ НЕ ЯВИТЬСЯ НА РАБОТУ!!!");
                else
                {
                    budget -= 20000;
                    Console.WriteLine(employee.Name + ' ' + employee.SurName + ": " + "20000");
                }
            }
            foreach (Worker employee in workers)
            {
                if (employee.IsHooky == true) Console.WriteLine(employee.Name + ' ' + employee.SurName + " ПОСМЕЛ НЕ ЯВИТЬСЯ НА РАБОТУ!!!");
                else
                {
                    budget -= 10000;
                    Console.WriteLine(employee.Name + ' ' + employee.SurName + ": " + "10000");
                }
            }
            foreach (Guard employee in guards)
            {
                if (employee.IsHooky == true) Console.WriteLine(employee.Name + ' ' + employee.SurName + " ПОСМЕЛ НЕ ЯВИТЬСЯ НА РАБОТУ!!!");
                else
                {
                    budget -= 8000;
                    Console.WriteLine(employee.Name + ' ' + employee.SurName + ": " + "8000");
                }
            }
            Console.WriteLine("\n-----------------------\nКОНЕЦ ВЫПЛАТ\n-----------------------\n");
        }
    }
}
