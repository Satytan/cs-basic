using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;


namespace ConsoleApp1.t1
{
    class IterableDaysOfWeek
    {
        private string[] days = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
        public IEnumerable<string> Days
        {
            get
            {
                yield return "Понедельник";
                yield return "Вторник";
                yield return "Среда";
                yield return "Четверг";
                yield return "Пятница";
                yield return "Суббота";
                yield return "Воскресенье";
            }
        }

    }
}
