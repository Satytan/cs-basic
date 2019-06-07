using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.t4
{
    // класс и его члены объявлены как public
    [Serializable]
    public class SimpleClass
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        // Стандартный конструктор - обязателен!
        public SimpleClass()
        { }
        public SimpleClass(string name, string phone)
        {
            Name = name;
            Phone = phone;
        }
        public override string ToString()
        {
            return Name + ": " + Phone;
        }
    }
}
