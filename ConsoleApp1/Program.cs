using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i, j;
            //test(out i, ref j);
            // Выполнение первого упражнения
            //t1.L1.letsDoIt(args);

            // Выполнение второго
            t2.L1.letsDoIt(args);


            ReadKey();
        }

        static public void test(out int i, ref int j)
        {
            i = 1;
            j = 1;
        }
    }
    class Parent
    {
        public void method1()
        {
            WriteLine("method1 - 1");
        }
        public virtual void method2()
        {
            WriteLine("method2 - 1");
        }
    }
    class Child : Parent
    {
        public new void method1()
        {
            WriteLine("method1 - 2");
        }
        public override void method2()
        {
            WriteLine("method2 - 2");
        }
    }
}
