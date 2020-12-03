using System;
using System.Collections.Generic;
using System.Text;

namespace Collection
{
    class ListCollection
    {
        public void Method()
        {
            var names = new List<string>();
            names.Add("Harish");
            names.Add("vikas");
            names.Add("prajwal");
            names.Add("raj");
            
            names.Remove("vikas");
            foreach(var name in names)
            {
                Console.WriteLine(name);
                
            }

           
        }
    }
}
