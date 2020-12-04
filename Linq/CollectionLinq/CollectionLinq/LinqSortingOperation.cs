using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectionLinq
{
    class LinqSortingOperation
    {
        public void OrderStudentName()
        {
            List<Student> st = new List<Student>()
            {
                new Student(){Id=101,Name="ankitha",location="Banglore",branch="cs"},
                new Student(){Id=103,Name="priyank",location="Mysore",branch="is"},
                new Student(){Id=107,Name="vinay",location="Chickmagalur",branch="me"},
                new Student(){Id=100,Name="ajay",location="Shivamogga",branch="eee"},
                new Student(){Id=205,Name="ashwith",location="Kerala",branch="is"},
            };
            //linq orderBy Ascending Order... 
            var studentName = st.OrderBy(x => x.Id);

            foreach(var stud in studentName)
            {
                Console.WriteLine(stud.Id);
            }
            //linq orderBy and ThenBy...
            Console.WriteLine("....................");
            var StudentName2 = st.OrderBy( x=>x.Name).ThenBy(x=>x.location);

            foreach(var stud1 in StudentName2)
            {
                Console.WriteLine("Id :{0},Name :{1}",stud1.Name,  stud1.location);
            }
            Console.WriteLine("....................");
            //var StudentName3 = st.OrderBy(x => x.location);
            //foreach(var stud2 in StudentName3)
            //{
            //    Console.WriteLine(stud2.location);
            //}

            //linq orderBy Desending order..
            Console.WriteLine("....................");
            var StudentNmae4 = st.OrderByDescending(x => x.Id);
            foreach(var stud3 in StudentNmae4)
            {
                Console.WriteLine(stud3.Id);
            }

            //linq orderBy and thenBydescebding order
            Console.WriteLine("....................");
            var StudentName5 = st.OrderBy(x => x.Name).ThenByDescending(x => x.Id);

            foreach (var stud4 in StudentName5)
            {
                Console.Write("id: {0}  ", stud4.Id);
                Console.WriteLine("location :{0} ", stud4.location);


            }


            Console.WriteLine("....................");
            //linq partition operators.


            //linq lookup operator.
            var std = st.ToLookup(x => x.branch);
            foreach(var lup in std)
            {
                Console.WriteLine(lup.Key);
            }


            Console.WriteLine("....................");
            //converting list to dictionary object.
            Console.WriteLine("ToDictionary Method() :");
            var student = st.ToDictionary(x => x.Id, x => x.Name);
            foreach(var stud6 in student)
            {
                Console.WriteLine(stud6);
            }
            Console.ReadLine();

        }
        class Student
        {
            public int Id;
            public string Name;
            public string location;
            public string branch;

        }
    }
}
