using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        public Random random = new Random();
        static void Main(string[] args)
        {
            Simulation job = new Simulation();
            job.Simulate();
        }
    }
}
