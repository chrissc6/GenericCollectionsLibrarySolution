using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollectionsLibrary
{
    public class StringDictionary 
    {
        private Dictionary<int, string> strs = new Dictionary<int, string>();

        public void Add(int key, string data)
        {
            strs.Add(key, data);
        }

        public string Get(int key)
        {
            return strs[key];
        }

       public List<string> Values()
        {
            return strs.Values.ToList();
        }
    }
}
