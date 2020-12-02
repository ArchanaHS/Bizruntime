
// array and arraylist are stored to access the key for value -> index key.
//key and value comination--> can stored it as
//key is predifined value. key->index.
//index is start with 0 and ends with  numbers of value-1.
// if we having some 30 of the index and value , if we want to access any one of this index , it is impossible to tell the index of the value.
// so to overcome this problem we are using Hashtable.


//Hash Table: is just like an array list.
//but it stored the value in key/value formate.
//in hashtable keys are user defined function.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace ArrayList1
{
    class Hashtable1
    {
        static void Main(string[] args)
        {
            //in hash table also can insert the value like an arraylist, but in arraylist we are only  inserting value.
            // in hash table we can add an item by using key and value of an item.
   
            Hashtable1 hash = new Hashtable1();
            hash.method();

        }
        private void method()
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
                Console.WriteLine(key+ ":" + ht[key]);
                Console.ReadLine();

            // but here values are not print an sequential order.
            //why? because -> the given key will internally generate an hash code value and stores it.
            // cashcode is numeric representaion of a value.
            Console.WriteLine("Hello".GetHashCode());

        }
    }
      

    }

