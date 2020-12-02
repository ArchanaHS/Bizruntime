using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedConcept
{
    class AddTwoInteger:AdditionClass
    {
        private int _total;
        public override object total
        {
            get
            {
                return _total;
            }
        }
        public AddTwoInteger(int value1, int value2)
        {
            _total = (int)this.AddTwoValue(value1, value2);
        }

        protected override object AddTwoValue(object value1, object value2)
        {
            //implicit convertion.

            int sum = (int)value1 + (int)value2;
            return sum;

        }
    }
}

