using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp1.t2
{
    abstract class Animal
    {
        protected string name;
        protected int age = 0;
        public Animal(string name, int age) : this(name)
        {
            this.age = age;
        }
        public Animal(string name)
        {
            this.name = name;
        }
        public Animal() {
            name = "Безымянное животное";
        }
        public void WhoAreYou() {
            WriteLine($"Я - {name}");
        }
    }
}
