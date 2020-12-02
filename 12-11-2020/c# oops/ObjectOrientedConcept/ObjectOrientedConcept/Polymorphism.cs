using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedConcept
{
    public class Employee1
    {

        public string FirstName;
        public string LastName;
        public string Email;

        public virtual void PrintFullName()
        {
            Console.WriteLine(FirstName + "" + LastName+"-FullTime");
        }
    }
    public class FullTimeEmploye1 : Employee1
    {
        public  override void PrintFullName()
        {
            Console.WriteLine(FirstName + "" + LastName+"-PartTime");
        }
    }
    public class PartTimeEmploye1 : Employee1
    {
        public override void PrintFullName()
        {
            Console.WriteLine(FirstName + "" + LastName + "-Temporary"); ;
        }
    }
    public class TemporaryEmploye : Employee1
    {
        public override void PrintFullName()
        {
            Console.WriteLine(FirstName + "" + LastName);
        }

    }

 
}
