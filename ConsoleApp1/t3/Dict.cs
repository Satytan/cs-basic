using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp1.t3
{
    // Данный класс хранит в себе коллекцию пар <ключ, значение>, где:
    // ключ - это слово,
    // значение - это список переводов слова
    [Serializable]
    class Dict
    {
        Dictionary<String, Words> translaters;

        public Dict()
        {
            this.Translaters = new Dictionary<String, Words>();
        }
        public Dict(string source)
        {
            this.Translaters = new Dictionary<String, Words>();
            string []lines = source.Split('\n');
            foreach (string line in lines)
            {
                string[] pair = line.Split('=');
                if (pair.Length == 2)
                {
                    this.Translaters.Add(pair[0], new Words(pair[1]));
                }
            }
        }

        // Добавление слова и его перевод
        // Если ранее для данного слова не было добавлено ни одного перевода, то будет создана новая запись.
        // Иначе будет найден существующий список переводов данного слова и к этому списку будет добавлен новый перевод.
        public void addWordTranslation(string word, string translation)
        {
            if (this.Translaters.ContainsKey(word))
            {
                Words translations;
                this.Translaters.TryGetValue(word, out translations);
                translations.words.Add(translation);
            }
            else {
                this.Translaters.Add(word, new Words(translation));
            }
        }
        
        internal Dictionary<string, Words> Translaters { get => translaters; set => translaters = value; }

        // Преобразование данных в текст для сохранения в файл
        public override string ToString()
        {
            List<String> result = new List<String>();
            foreach (KeyValuePair<String, Words> pair in this.translaters)
            {
                result.Add(pair.Key + "=" + pair.Value.ToString());
            }
            return String.Join("\n", result);
        }
    }
 

}
