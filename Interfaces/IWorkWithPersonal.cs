using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    interface IWorkWithPersonal
    {
        void Work(ref List<Geologist> geologists,ref List<Mechanic> mechanics, 
            ref List<Worker> workers, ref List<Guard> guards, ref int budget, ref int projectNumber);
    }
}
