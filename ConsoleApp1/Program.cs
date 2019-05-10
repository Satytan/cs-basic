using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using static System.Console;

namespace ConsoleApp1
{
    [Serializable]
    class Test {
        public int i = 5;
        public int j = 5;
    }
    class Program
    {
        static void Main(string[] args)
        {
            t3.Translator.letsDoIt(args);
            return;
            //int i, j;
            //test(out i, ref j);
            // Выполнение первого упражнения
            //t1.L1.letsDoIt(args);
            Test t = new Test(), d;
            t.j = 10;
            BinaryFormatter bin = new BinaryFormatter();

            // Выполнение второго
            //t3.L1.letsDoIt(args);
            using (FileStream fs = new FileStream("./../../base.bin", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                bin.Serialize(fs, t);
            }
            using (FileStream fs = new FileStream("./../../base.bin", FileMode.Open, FileAccess.Read, FileShare.None))
            {
                d = (Test)bin.Deserialize(fs);
            }
            WriteLine(d.j);

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
