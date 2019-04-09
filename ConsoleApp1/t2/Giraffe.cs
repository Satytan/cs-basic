using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp1.t2
{
    class Giraffe : Animal
    {
        public Giraffe(string name, int age) : base(name, age) { }
        public Giraffe(string name) : base(name) { }
        public Giraffe() : base() { }
    }
}
