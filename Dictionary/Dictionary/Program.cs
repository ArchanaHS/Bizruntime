using System;

using System.Collections.Generic;


namespace DictionaryCust
{
    class CustomerProgram
    {
        public class Customer
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public int Salary { get; set; }
        }
        public void method()
        {
            Customer customer1 = new Customer()
            {
                ID = 101,
                Name = "John",
                Salary = 5500,

            };

            Customer customer2 = new Customer()
            {
                ID = 102,
                Name = "Vinay",
                Salary = 5000,

            };

            Customer customer3 = new Customer()
            {
                ID = 105,
                Name = "Jai",
                Salary = 6500,

            };


            Dictionary<int, Customer> disctonaryCustomers = new Dictionary<int, Customer>();

            disctonaryCustomers.Add(customer1.ID, customer1);
            disctonaryCustomers.Add(customer2.ID, customer1);
            disctonaryCustomers.Add(customer3.ID, customer1);

            //finding an customer detail by using id.
            Customer customur105 = disctonaryCustomers[105];
            // Console.WriteLine("Id={0} , Name={1} , Salary={2}", customur105.ID, customur105.Name, customur105.Salary);
            foreach (var  customerKeyvaluepair in disctonaryCustomers)
            {
                Console.WriteLine("key={0}", customerKeyvaluepair.Key);
                Customer cust = customerKeyvaluepair.Value;
                Console.WriteLine("ID={0},Name={1},Salary={2}", cust.ID, cust.Name, cust.Salary);
                Console.WriteLine("................................");
            }

        }

        static void Main(string[] args)
        {

            CustomerProgram ctm = new CustomerProgram();
            ctm.method();
        }
       
    }
}

