using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.t4
{
    // класс и его члены объявлены как public
    [Serializable]
    public class TwoLevelClass
    {
        // класс и его члены объявлены как public
        public string Name { get; set; }
        public SimpleClass simpleClass{ get; set; }
        public TwoLevelClass()
        { }

        public override string ToString()
        {
            return Name + ": " + simpleClass.ToString();
        }
    }
}
