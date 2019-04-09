using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp1.t2
{
    class L1
    {
        public static void letsDoIt(string[] args)
        {
            Animal[] animals = new Animal[3];
            animals[0] = new Cow("Бурёнка");
            animals[1] = new Duck("Селезень");
            animals[2] = new Giraffe("Жираф");
            WriteLine("Представление животных:");
            foreach (Animal animal in animals)
            {
                animal.WhoAreYou();
            }
            WriteLine("Слушаем животных:");
            foreach (Animal animal in animals)
            {
                if (animal is Speaking)
                {
                    ((Speaking)animal).Say();
                }
            }
            WriteLine("Отпускаем животных:");
            foreach (Animal animal in animals)
            {
                if (animal is Flyable)
                {
                    (animal as Flyable).Fly();
                }
            }
        }
    }
}
