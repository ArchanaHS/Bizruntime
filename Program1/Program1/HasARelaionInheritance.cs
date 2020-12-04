using System;
using System.Collections.Generic;
using System.Text;

namespace Program1
{
    public class Address
    {
        public string addressLine, city, state;
        public Address(string addressLine,string city, string state)
        {
            this.addressLine = addressLine;
            this.city = city;
            this.state = state;
        }

    }
    public class Employee1
    {
        public int id;
        public string Name;
        public Address address;//Has a Relation.

        public Employee1(int id,string Name, Address address)
        {
            this.id = id;
            this.Name = Name;
            this.address = address;
        }
        public void Display()
        {
            Console.WriteLine(id + " " + Name + "" + address.addressLine + "" + address.city + "" + address.state);
        }

    }
}
