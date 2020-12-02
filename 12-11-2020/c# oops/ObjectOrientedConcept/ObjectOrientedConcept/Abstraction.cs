using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedConcept
{
    abstract class AdditionClass
    {
        abstract public object total { get; }//property
        abstract protected object AddTwoValue(object value1, object value2);//method
    }
}
