using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Director
    {
        private readonly string directorName = "Сорокин Олег Викторович";
        private string project;
        Random random = new Random();
        public void Work(ref int budget, ref int projectNumber)
        {
            budget = random.Next(100000, 100000000);
            Console.WriteLine(directorName + " выбирает проект.\n");
            if (budget > 50000000) {project = "Расследование золотых приисков Амазонки\n"; projectNumber = 1; }
            if (50000000 > budget && budget > 5000000) { project = "Поиски нефти в Сибири\n"; projectNumber = 2; }
            if (budget < 5000000) { project = "Дача для Михалыча\n"; projectNumber = 3; }
            Console.WriteLine(directorName + " выбрал проект: " + project);
            Console.WriteLine("С бюджетом: " + budget +"\n");
        }
    }
}
