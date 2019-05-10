using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Soap;


namespace ConsoleApp1.t3
{
    class Translator
    {
        public static void letsDoIt(string[] args)
        {
            Dict dict = new Dict();
            Words newWords = new Words();
            newWords.words.Add("word1");
            newWords.words.Add("word2");
            dict.Translaters.Add("from1", newWords);
            SoapFormatter sf = new SoapFormatter();
            using (Stream f = File.Create("test.xml")) {
                using (StreamWriter sw = new StreamWriter(f, Encoding.Unicode))
                {
                    sw.Write(dict.ToString());
                }
            }
        }
    }
}
