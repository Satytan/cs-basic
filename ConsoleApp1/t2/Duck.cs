using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp1.t2
{
    class Duck : Animal, Speaking, Flyable
    {
        public Duck(string name, int age) : base(name, age) { }
        public Duck(string name) : base(name) { }
        public Duck() : base() { }
        public void Fly()
        {
            WriteLine($"{name} полетел(а).");
        }

        public void Say()
        {
            WriteLine($"{name} говорит \"Кря-кря\".");
        }
    }
}
