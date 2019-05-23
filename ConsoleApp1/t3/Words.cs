using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.t3
{
    // Данный класс хранит в себе список переводов слова
    [Serializable]
    class Words
    {
        List<String> _words;

        public Words()
        {
            this.words = new List<String>();
        }
        // Конструктор от текстовой строки для восстановления данных из текстовой строки. В т.ч. для загрузки из файла.
        // Для разделения слов используется разделитель `,`. Т.е., в т.ч. допустимо передавать одно и более слов.
        public Words(string translations)
        {
            this.words = new List<String>();
            string[] trs = translations.Split(',');
            foreach (string tr in trs)
            {
                this.words.Add(tr);
            }
            
        }

        public List<string> words { get => _words; set => _words = value; }

        // Преобразование данных в текст для сохранения в текстовый файл
        public override string ToString()
        {
            return String.Join(",", _words);
        }
    }
}
