using System;
using System.Collections.Generic;
using System.Text;
namespace ObjectOrientedConcept
{
    class Program
    {
        static void Main(string[] args)
        {
            var acc = new Account();

            //acc.Withdraw(1000);
            //acc.Deposit(7000);

            Console.WriteLine("..................................");
            FullTimeEmploye fl = new FullTimeEmploye();
            fl.FirstName = "Ranjini ";
            fl.LastName = "Ram";
            fl.Email = "ranjini@gmail.com";
            fl.YearlySalary = 10000;
            fl.PrintFullName();

            PartTimeEmploye pt = new PartTimeEmploye();
            pt.FirstName = "Ajay ";
            pt.LastName = "Kumar";
            pt.Email = "ajay@gmail,com";
            pt.HourlyRate = 250;
            pt.PrintFullName();

            Console.WriteLine("..................................");

            /*A a1 = new A();
            a1.FirstName = "Zafar";*/
            Childclass ch = new Childclass();


            Console.WriteLine("..................................");

            AdditionClass addtwovalue = new AddTwoDouble(314534.545, 66262.7484);

            // Console.WriteLine(addtwovalue);
            // AdditionClass addtwovalue1 = new AddTwoInteger(314534, 66262);


            Console.WriteLine("..................................");
            Employee1[] emp = new Employee1[4];
            emp[0] = new Employee1();
            emp[1] = new FullTimeEmploye1();
            emp[2] = new PartTimeEmploye1();
            emp[3] = new TemporaryEmploye();

            foreach(Employee1 ee in emp)
            {
                ee.PrintFullName();
            }








        }
    }
}
