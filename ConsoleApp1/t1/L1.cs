using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace ConsoleApp1.t1
{
    class L1
    {
        public static void letsDoIt(string[] args)
        {
            WriteLine("Task 1");
            IterableMonth months = new IterableMonth();
            IterableDaysOfWeek days = new IterableDaysOfWeek();

            WriteLine("Дни недели:");
            foreach (string day in days.Days) {
                WriteLine(day);
            }
            WriteLine("Месяцы:");
            foreach (string month in months)
            {
                WriteLine(month);
            }

        }

    }
}
