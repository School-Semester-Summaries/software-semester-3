using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTest.Animals
{
    internal class Cat : Animal
    {
        string _name = "cat";
        int _health = 90;

        public Cat()
        {
            Name = _name;
            Health = _health;
        }

        public override string Attack1()
        {
            return "purrr";
        }
    }
}
