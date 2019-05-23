using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Soap;
using static System.Console;

namespace ConsoleApp1.t3
{
    class Translator
    {
        public static void letsDoIt(string[] args)
        {
            bool exit = false;
            string command;
            Dict dict = new Dict();
            do
            {
                WriteLine("> Введите команду (для получения справки используется команда \"помощь\"");
                command = ReadLine();
                exit = command == "выход";
                string fileName;
                switch (command) {
                    case "перевод":
                        WriteLine("> Введите слово");
                        string word = ReadLine();
                        WriteLine("> Введите перевод");
                        string translation = ReadLine();
                        dict.addWordTranslation(word, translation);
                        WriteLine("*перевод добавлен*");
                        break;
                    case "тест":
                        dict.addWordTranslation("слово 1", "перевод 1");
                        dict.addWordTranslation("слово 1", "перевод 2");
                        dict.addWordTranslation("слово 1", "перевод 3");
                        dict.addWordTranslation("слово 2", "перевод 4");
                        dict.addWordTranslation("слово 2", "перевод 5");
                        WriteLine("*данные успешно загружены*");
                        break;
                    case "вывод":
                        WriteLine(dict);
                        break;
                    case "сохранить":
                        WriteLine("> Введите название файла:");
                        fileName = ReadLine();
                        // Создание потока
                        using (Stream f = File.Create(fileName))
                        {
                            // Обёртка для потока, с которой проще работать
                            using (StreamWriter sw = new StreamWriter(f, Encoding.Unicode))
                            {
                                sw.Write(dict.ToString());
                            }
                        }
                        break;
                    case "загрузить":
                        WriteLine("> Введите название файла:");
                        fileName = ReadLine();
                        // Создание потока
                        using (Stream f = File.OpenRead(fileName))
                        {
                            // Обёртка для потока, с которой проще работать
                            using (StreamReader sw = new StreamReader(f, Encoding.Unicode))
                            {
                                string source = sw.ReadToEnd();
                                if (source.Length > 2) {
                                    dict = new Dict(source);
                                }
                            }
                        }
                        break;
                    case "помощь":
                        printHelp();
                        break;
                }
            } while (!exit);
            //SoapFormatter sf = new SoapFormatter();
            
        }

        public static void printHelp() {
            WriteLine(
                "Список команд:\n" +
                "выход\n" +
                "помощь\n" +
                "перевод - добавить перевод\n" +
                "сохранить\n" +
                "загрузить\n" +
                "тест - загрузить тестовые данные\n" +
                "вывод - вывести словарь на экран\n" +
                ""
                );
        }
    }
}
