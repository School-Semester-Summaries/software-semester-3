using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTest
{
    internal class Human
    {
        public Animal Pet { get; private set; }

        public Human(Animal pet)
        {
            Pet = pet;
        }
    }
}
