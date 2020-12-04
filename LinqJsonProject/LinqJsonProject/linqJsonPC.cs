
using System;
using System.Collections.Generic;
using System.Text;

namespace LinqJsonProject
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public string AcademicYear { get; set; }
        public List<Course> Courses { get; set; }
    }
    public class Course
    {
        public int CId { get; set; }
        public string CName { get; set; }
    }

    public class StudentDatabase:List<Student>
    {
        public StudentDatabase()
        {
            Add(new Student()
            {
                Id = 1,
                Name = "Akash",
                AcademicYear = "First",
                Courses = new List<Course>()
                {
                 new Course() {CId=101,CName="C++" },
                 new Course() {CId=102,CName="C" },
                 new Course() {CId=103,CName="Visual Basic" }
                }

            });
            Add(new Student()
            {
                Id = 2,
                Name = "Anjana",
                AcademicYear = "Second",
                Courses = new List<Course>()
                {
                 new Course() {CId=101,CName="C++" },
                 new Course() {CId=102,CName="C" },
                 new Course() {CId=103,CName="Visual Basic" }
                }

            });
            Add(new Student()
            {
                Id = 3,
                Name = "Ankitha",
                AcademicYear = "Third",
                Courses = new List<Course>()
                {
                 new Course() {CId=101,CName="C++" },
                 new Course() {CId=102,CName="C" },
                 new Course() {CId=103,CName="Visual Basic" }
                }

            });




        }
    }
}
