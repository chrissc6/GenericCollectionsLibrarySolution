using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericCollectionsLibrary;

namespace TestGCL
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GenericCollections.About);

            var strDictionary = new StringDictionary();
            strDictionary.Add(7, "Irena");
            strDictionary.Add(4, "Sammy");
            strDictionary.Add(25, "Ben");
            strDictionary.Add(42, "Seth");
            strDictionary.Add(97, "Ken");
            strDictionary.Add(55, "Kellan");
            strDictionary.Add(3, "Chris");

            Console.WriteLine($"The person with the fav nbr of 42 is {strDictionary.Get(42)}");

            foreach (var i in strDictionary.Values())
            {
                Console.WriteLine(i);
            }


            var strings = new StringList();
            strings.Add("abc");
            strings.Add("def");
            strings.Add("ghi");
            strings.Add("xxx", "yyy");
            strings.Add("xxx", "yyy", "lll");
            strings.Add("xxx", "yyy", "lll", "rrr");
            strings.Count();
            foreach (var i in strings)
            {
                Console.WriteLine(i);
            }
        }
    }
}
