using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTest
{
    abstract class Animal
    {
        public string Name { get; internal set; }
        public int Health { get; internal set; }

        public abstract string Attack1();
    }
}
