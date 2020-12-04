using System;
using System.Collections.Generic;
using System.Text;

namespace OopsConcept
{
    class Inheritance
    {

        private int value = 10;
       


        public class B : Inheritance
        {
            public int GetValue()
            {
                return this.value;
            }
        }
        public class C : Inheritance
        {
            public int GetValue()
            {
                return this.value;
            }
        }
        }
    
}

