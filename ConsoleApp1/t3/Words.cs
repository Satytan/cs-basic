using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.t3
{
    [Serializable]
    class Words
    {
        List<String> _words;

        public Words()
        {
            this.words = new List<String>();
        }

        public List<string> words { get => _words; set => _words = value; }

        public override string ToString()
        {
            return String.Join(":", _words);
        }
    }
}
