using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp1.t3
{
    class L1
    {
        public static void letsDoIt(string[] args)
        {
            NameValueCollection dict = new NameValueCollection();
            dict.Add("key", "value 1");
            dict.Add("key", "value 2");
            foreach (string key in dict)
            {
                WriteLine(key + ":");
                foreach (string val in dict.GetValues(key))
                {
                    WriteLine("\t>" + val);
                }
            }
        }
    }
}
