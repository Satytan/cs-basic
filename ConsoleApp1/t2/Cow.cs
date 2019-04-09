using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp1.t2
{
    class Cow : Animal, Speaking
    {
        public Cow(string name, int age) : base(name, age) { }
        public Cow(string name) : base(name) { }
        public Cow() : base() { }

        public void Say()
        {
            WriteLine($"{name} говорит \"Мууууу\".");
        }
    }
}
