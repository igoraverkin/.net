using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    abstract class NameGenerator
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public bool IsHooky { get; set; }

        public NameGenerator(string name, string surName, bool isHooky=false)
        {
            Name = name;
            SurName = surName;
            IsHooky = isHooky;
        }
    }
}
