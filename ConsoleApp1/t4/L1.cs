using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Xml.Serialization;
using System.IO;

namespace ConsoleApp1.t4
{
    class L1
    {
        public static void letsDoIt(string[] args)
        {
            // Пример с простым классом
            WriteLine("Пример с простым классом");
            sampleSimple();
            WriteLine();

            // Пример с классом со вложенными объектами
            WriteLine("Пример с классом со вложенными объектами");
            sampleComplex();
            WriteLine();

            // Прмиер с массивом объектов
            WriteLine("Пример с массивом объектов");
            sampleArray();
            WriteLine();

            // Пример с объектом с коллекцией
            WriteLine("Пример с объектом с коллекцией");
            sampleCollection();
            WriteLine();

            Console.ReadKey();


        }

        // Десереализация простого объекта
        public static void sampleSimple()
        {
            SimpleClass simple = new SimpleClass("Имя записи", "Phone");
            WriteLine("Исходный объект: " + simple.ToString());
            XmlSerializer formatterSimpleClass = new XmlSerializer(typeof(SimpleClass));
            // получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream("simple.xml", FileMode.OpenOrCreate))
            {
                formatterSimpleClass.Serialize(fs, simple);
            }
            // десериализация
            using (FileStream fs = new FileStream("simple.xml", FileMode.OpenOrCreate))
            {
                SimpleClass newSimple = (SimpleClass)formatterSimpleClass.Deserialize(fs);
                Console.WriteLine("Десериализованный объект: " + newSimple.ToString());
            }
        }

        // Десереализация объекта с вложенным объектом
        public static void sampleComplex()
        {
            TwoLevelClass complex = new TwoLevelClass();
            complex.Name = "Тест";
            complex.simpleClass = new SimpleClass("Имя записи", "Phone");
            WriteLine("Исходный объект: " + complex.ToString());
            XmlSerializer formatterComplexClass = new XmlSerializer(typeof(TwoLevelClass));

            using (FileStream fs = new FileStream("complex.xml", FileMode.OpenOrCreate))
            {
                formatterComplexClass.Serialize(fs, complex);
            }
            // десериализация
            using (FileStream fs = new FileStream("complex.xml", FileMode.OpenOrCreate))
            {
                TwoLevelClass newComplex = (TwoLevelClass)formatterComplexClass.Deserialize(fs);
                Console.WriteLine("Десериализованный объект: " + newComplex.ToString());
            }
        }

        // Десереализация массива объектов
        public static void sampleArray()
        {
            SimpleClass simple1 = new SimpleClass("Имя записи 1", "Phone 1"),
                simple2 = new SimpleClass("Имя записи 2", "Phone 2");
            SimpleClass[] simpleArray = new SimpleClass[] { simple1, simple2 };

            WriteLine("Исходные объекты:");
            foreach (SimpleClass simple in simpleArray) {
                WriteLine("\t> " + simple);
            }
            XmlSerializer formatterSimpleClass = new XmlSerializer(typeof(SimpleClass[]));
            // получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream("simple-array.xml", FileMode.OpenOrCreate))
            {
                formatterSimpleClass.Serialize(fs, simpleArray);
            }
            // десериализация
            using (FileStream fs = new FileStream("simple-array.xml", FileMode.OpenOrCreate))
            {
                SimpleClass[] newSimpleArray = (SimpleClass[])formatterSimpleClass.Deserialize(fs);
                Console.WriteLine("Десериализованные объекты:");
                foreach (SimpleClass simple in newSimpleArray)
                {
                    WriteLine("\t> " + simple);
                }
            }

        }

        // Десереализация объекта с коллекцией
        public static void sampleCollection()
        {
            CollectionClass record = new CollectionClass();
            record.Name = "Тестовая запись";
            record.Phones.Add("phone 1");
            record.Phones.Add("phone 2");
            record.Phones.Add("phone 3");
            WriteLine("Исходный объект: " + record);
            XmlSerializer formatter = new XmlSerializer(typeof(CollectionClass));

            using (FileStream fs = new FileStream("collection.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, record);
            }
            // десериализация
            using (FileStream fs = new FileStream("collection.xml", FileMode.OpenOrCreate))
            {
                CollectionClass newCollection = (CollectionClass)formatter.Deserialize(fs);
                Console.WriteLine("Десериализованный объект: " + newCollection);
            }

        }
    }
}
