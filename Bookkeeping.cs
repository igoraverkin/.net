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
                    budget -= employee.Price;
                    Console.WriteLine(employee.Name + ' ' + employee.SurName + ": " + "{0}",employee.Price);
                }
            }
            foreach (Mechanic employee in mechanics)
            {
                if (employee.IsHooky == true) Console.WriteLine(employee.Name + ' ' + employee.SurName + " ПОСМЕЛ НЕ ЯВИТЬСЯ НА РАБОТУ!!!");
                else
                {
                    budget -= employee.Price;
                    Console.WriteLine(employee.Name + ' ' + employee.SurName + ": " + "{0}", employee.Price);
                }
            }
            foreach (Worker employee in workers)
            {
                if (employee.IsHooky == true) Console.WriteLine(employee.Name + ' ' + employee.SurName + " ПОСМЕЛ НЕ ЯВИТЬСЯ НА РАБОТУ!!!");
                else
                {
                    budget -= employee.Price;
                    Console.WriteLine(employee.Name + ' ' + employee.SurName + ": " + "{0}", employee.Price);
                }
            }
            foreach (Guard employee in guards)
            {
                if (employee.IsHooky == true) Console.WriteLine(employee.Name + ' ' + employee.SurName + " ПОСМЕЛ НЕ ЯВИТЬСЯ НА РАБОТУ!!!");
                else
                {
                    budget -= employee.Price;
                    Console.WriteLine(employee.Name + ' ' + employee.SurName + ": " + "{0}", employee.Price);
                }
            }
            Console.WriteLine("\n-----------------------\nКОНЕЦ ВЫПЛАТ\n-----------------------\n");
        }
    }
}
