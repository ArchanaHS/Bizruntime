using System;

namespace PassingReference
{
    public class Student
    {
        public string StudentName { get; set; }
    }
    public  class Program
    {
        public static void ChangeReferenceType(Student std2)
        {
            std2.StudentName = "arjith";
        }
   
        static void Main(string[] args)
        {
            Student std1 = new Student();
            std1.StudentName = "Bill";
            ChangeReferenceType(std1);
            Console.WriteLine(std1.StudentName);
        }
    }
}
