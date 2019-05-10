using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.t3
{
    [Serializable]
    class Dict
    {
        Dictionary<String, Words> translaters;

        public Dict()
        {
            this.Translaters = new Dictionary<String, Words>();
        }

        internal Dictionary<string, Words> Translaters { get => translaters; set => translaters = value; }
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
