using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp1.t4
{
    // класс и его члены объявлены как public
    [Serializable]
    public class CollectionClass
    {
        public string Name { get; set; }

        // Описание сериализации коллекции
        [XmlArray("Phones")]
        [XmlArrayItem("Phone")]
        public List<String> Phones { get; set; }

        public CollectionClass()
        {
            Phones = new List<string>();
        }

        public override string ToString()
        {
            return Name + ": " + String.Join(", ", Phones.ToArray());
        }
    }
}
