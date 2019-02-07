using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollectionsLibrary
{
    public class StringList : List<string>
    {
        public void Add(string s1, string s2, string s3, string s4)
        {
            this.Add(s1);
            this.Add(s2);
            this.Add(s3);
            this.Add(s4);
        }

        public void Add(string s1, string s2, string s3)
        {
            this.Add(s1);
            this.Add(s2);
            this.Add(s3);
        }

        public void Add(string s1, string s2)
        {
            //base.Add(s1); //calling method on inherited class, the base class
            this.Add(s1); //calling method on stringlist class, this class, better for future
            this.Add(s2);

        }

             

        //constr
        public StringList() : base()
        { }
    }
}
