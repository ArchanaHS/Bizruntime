using System;
using System.Collections.Generic;
using System.Text;

namespace Collection
{
    class SortedListColection
    {
        public void Method8()
        {
            SortedList<string, string> names = new SortedList<string, string>();
            names.Add("1", "Sonoo");
            names.Add("4", "Peter");
            names.Add("5", "James");
            names.Add("3", "Ratan");
            names.Add("2", "Irfan");
            foreach (KeyValuePair<string, string> kv in names)
            {
                Console.WriteLine(kv.Key + " " + kv.Value);
            }
        }
    }
}
