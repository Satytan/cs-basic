using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp1.t1
{
    class IterableMonth : IEnumerable
    {
        private string[] month = { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };
        public IEnumerator GetEnumerator()
        {
            for (int index = 0; index < month.Length; index++)
            {
                yield return month[index];
            }
        }
    }
}
