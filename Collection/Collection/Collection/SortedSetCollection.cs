using System;
using System.Collections.Generic;
using System.Text;

namespace Collection
{
    class SortedSetCollection
    {
        public void Method2()
        {
            var names = new SortedSet<string>();
            names.Add("bhavya");
            names.Add("Zafar");
            names.Add("Dhanya");
            names.Add("ankitha");
            names.Add("Rahul");
            names.Add("venki");

            names.Remove("venki");
            foreach(var name in names)
            {
                Console.WriteLine(name);
            }
		names.clear();
	     foreach(var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
