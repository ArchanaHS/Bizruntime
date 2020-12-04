using System;
using System.Collections.Generic;

namespace DelegatesFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> emplist = new List<Employee>();
            emplist.Add(new Employee { id = 101, name = "kavitha", salary = 26000, department = "marketing" });
            emplist.Add(new Employee { id = 102, name = "sukesh", salary = 6000, department = "marketing" });
            emplist.Add(new Employee { id = 104, name = "vyshnav", salary = 16000, department = "It" });
            emplist.Add(new Employee { id = 106, name = "preethi", salary = 24000, department = "engineering" });
            emplist.Add(new Employee { id = 109, name = "sandya", salary = 56000, department = "IT" });

            //create delegate instance.
            //instance of creating delegate instance and pointing to function we can use lamda expression.
           // Ispromatable isPromotable = new Ispromatable( promote);
            Employee.promoteEmployee(emplist, emp=>emp.salary>50000);


        }
    //    public static bool promote (Employee emp)
    //    {
    //        if (emp.salary >= 20000)
    //        {
    //            return true;
    //        }
    //        else
    //            return false;
    //    }

                
    }
    //created delegate
    delegate bool Ispromatable(Employee emp);
    class Employee
    {
       public int id { get; set; }
        public string name { get; set; }
        public int salary { get; set; }
        public string department { get; set; }

        public static void promoteEmployee(List<Employee> employeelist, Ispromatable isEligible)
        {
            foreach(Employee employee in employeelist)
            {
                if(isEligible(employee))
                {
                    Console.WriteLine(employee.name+" getting heighest salary..");

                }
                else
                {

                }
            }

        }

    }
}
