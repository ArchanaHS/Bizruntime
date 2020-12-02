using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedConcept
{
    class AddTwoDouble : AdditionClass
    {

        private double _total;
        public override object total
        {
            get
            {
                return _total;
            }
        }
        public AddTwoDouble(double value1,double value2)
        {
            _total = (double)this.AddTwoValue(value1, value2);
        }

        protected override object AddTwoValue(object value1, object value2)
        {
            //implicit convertion.

            double sum = (double)value1 + (double)value2;
            return sum;

        }
    }
}
