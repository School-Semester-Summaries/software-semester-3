using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTest.Animals
{
    internal class Dog : Animal
    { 
        string _name = "dog";
        int _health = 105;

        public override string Attack1()
        {
            return "woof";
        }


        public Dog()
        {
            Name = _name;
            Health = _health;
        }
    }
}
