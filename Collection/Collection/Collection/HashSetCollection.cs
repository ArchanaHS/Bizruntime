using System;
using System.Collections.Generic;
using System.Text;

namespace Collection
{
    class HashSetCollection
    {
        public void Method1()
        {
            var names = new HashSet<string>();
            names.Add("abhi");
            names.Add("swathi");
            names.Add("nish");
            names.Add("ashu");

            names.Remove("nish");

            //creating another hash set
            Hashset<string> names2 = new Hashset<string>();
            names2.Add("abc");
            names2.Add("swathi");
            names2.Add("ashu");
            names2.Add("def");
            names2.Add("ghi");

            names1.UnionWith(names2);
            //names1.IntersectWith(names2);
           // names1.ExceptWith(names2);
            foreach (var name in names)
            {
                Console.WriteLine(name);
                
                
            }

        }
    }
}
