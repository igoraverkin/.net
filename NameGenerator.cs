using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    abstract class NameGenerator
    {
        public string Name { get; private set; }
        public string SurName { get; private set; }
        public bool IsHooky { get; set; }
        public virtual int Price {get;set;}

        public NameGenerator(string name, string surName, int price, bool isHooky=false)
        {
            Name = name;
            SurName = surName;
            IsHooky = isHooky;
            Price = price;
        }

    }
}
