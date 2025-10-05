using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentList
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Grade { get; set; }
        public string Major {  get; set; }

        public Student(string name, int age, string grade, string major)
        {
            this.Name = name;
            this.Age = age;
            this.Grade = grade;
            this.Major = major;
        }
    }
}
