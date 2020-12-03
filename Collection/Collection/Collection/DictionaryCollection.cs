using System;
using System.Collections.Generic;
using System.Text;

namespace Collection
{
    class DictionaryCollection
    {
        public void Method6()
        {
            Dictionary<string, string> names = new Dictionary<string, string>();
            names.Add("1", "Sonoo");
            names.Add("2", "Peter");
            names.Add("3", "James");
            names.Add("4", "Ratan");
            names.Add("5", "Irfan");

            foreach (KeyValuePair<string, string> kv in names)
            {
                Console.WriteLine(kv.Key + " " + kv.Value);
            }
        }
    }
}
