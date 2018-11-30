using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApp1
{
    class Simulation
    {
        public void Simulate()
        {
            while (true)
            {
                List<Geologist> allGeologists = new List<Geologist>();
                List<Mechanic> allMechanics = new List<Mechanic>();
                List<Guard> allGuards = new List<Guard>();
                List<Worker> allWorkers = new List<Worker>();
                int budget = 0; int projectNumber = 0;
                Director director = new Director();
                Personal_Department personal = new Personal_Department();
                Bookkeeping bookkeeping = new Bookkeeping();

                ///START
                director.Work(ref budget, ref projectNumber);
                Console.WriteLine("\n\n---------------------------------");
                
                personal.Work(ref allGeologists, ref allMechanics, ref allWorkers, ref allGuards, ref budget, ref projectNumber);
                Console.WriteLine("\n\n---------------------------------");
                
                foreach (Geologist emloyee in allGeologists)
                    emloyee.Work();
                Console.WriteLine("");
                foreach (Mechanic employee in allMechanics)
                    employee.Work();
                Console.WriteLine("");
                foreach (Guard employee in allGuards)
                    employee.Work();
                Console.WriteLine("");
                foreach (Worker employee in allWorkers)
                    employee.Work();
                Console.WriteLine("");


                bookkeeping.Work(ref allGeologists, ref allMechanics, ref allWorkers, ref allGuards, ref budget, ref projectNumber);
                
                Console.WriteLine("Оставшийся бюджет: " + budget);
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
