using System;
using System.Collections;


namespace Collection
{
    class HashTableCollection
    {
        public void Method10()
        {
           
            Hashtable ht = new Hashtable();

            ht.Add("Eid", 1001);
            ht.Add("Ename", "abhi");
            ht.Add("Job", "Manager");
            ht.Add("salary", 20000);
            ht.Add("mid", 2002);
            ht.Add("Email", "abhi12@gmail.com");
            ht.Add("phone", 9632929545);

            ht.Add("Dname", "Sales");
            ht.Add("Location", "Banglore");
            ht.Add("Did", 30);


            // if we want to access only one value we can use this method. object of key.
            Console.WriteLine(ht["Email"]);


            // if we want access all value at a time , we can use foreach loop.
            foreach (Object key in ht.Keys)
                Console.WriteLine(key + ":" + ht[key]);
            Console.ReadLine();

            // but here values are not print an sequential order.
            //why? because -> the given key will internally generate an hash code value and stores it.
            // cashcode is numeric representaion of a value.
            Console.WriteLine("Hello".GetHashCode());

        }
    }
}
