using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedConcept
{
    public class Employee
    {

        public string FirstName;
         public string LastName;
        public  string Email;

        public void PrintFullName()
        {
            Console.WriteLine(FirstName + "" + LastName);
        }
    }
    public class FullTimeEmploye : Employee
    {
        public float YearlySalary;
    }
    public class PartTimeEmploye : Employee
    {
        public float HourlyRate;
    }

  /*  public class   A: PartTimeEmploye
    {
        
    }*/
}
