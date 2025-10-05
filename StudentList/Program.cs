using System;
using System.Xml;
using StudentList;

class Program
{
    static void Main(string[] args)
    {
        var students = new List<Student>();

        students.Add(new Student(name: "Ram Hari", age: 17, grade: "A+", major: "Science"));
        students.Add(new Student(name: "Kiran Niraula", age: 18, grade: "A", major: "Science"));
        students.Add(new Student(name: "Shree Sundari", age: 17, grade: "A", major: "Management"));
        students.Add(new Student(name: "Aman Gurung", age: 18, grade: "B+", major: "Law"));
        students.Add(new Student(name: "Maiya Shakya", age: 17, grade: "A", major: "Humanities"));
        students.Add(new Student(name: "Shyam Maharjan", age: 16, grade: "B", major: "Management"));

        //----| filter students by grade|----

        var StudentWithGradeA = (from student in students
                                where student.Grade == "A"
                                select student).ToList();
        //var StudentWithGradeA = students.Where(student => student.Grade == "A").ToList();

        foreach(var student in StudentWithGradeA)
        {
            Console.WriteLine(student.Name);
        }

        Console.WriteLine();

        //----| sort students by age |----

        var StudentAgeSortedInAscendingOrder = (from student in students
                               orderby student.Age ascending
                               select student).ToList();

        //var StudentAgeSortedInDescendingOrder = students.OrderByDescending(student => student.Age).ToList();

        foreach(var student in StudentAgeSortedInAscendingOrder)
        {
            Console.WriteLine($"{student.Name} = {student.Age}");
        }

        Console.WriteLine();

        //---| group students by major |---

        var studentsGroupedByMajor = from student in students
                                     group student by student.Major into majorGroup  //this seperates the students in their respective major group
                                     select new
                                     {
                                         Major = majorGroup.Key,
                                         Students = majorGroup.ToList()
                                     };

        /*
        var studentsGroupedByMajor = students.GroupBy(student => student.Major)
                                     .Select(majorGroup => new
                                     {
                                         Major = majorGroup.Key,
                                         Students = majorGroup.ToList()
                                     });
        */

        foreach (var group in studentsGroupedByMajor)
        {
            Console.WriteLine(group.Major);
            foreach(var student in group.Students)
            {
                Console.WriteLine($" -> {student.Name}");
            }
            Console.WriteLine();
        }


        //---| average grade|---

        // Define ordered grade scale
        var gradeScale = new List<string>
        {
            "A+", "A", "B+", "B",
            "C+", "C", "D+", "D", "F"
        };

        // Convert grades to positions
        var positions = students.Select(student => gradeScale.IndexOf(student.Grade));

        // Average position
        double avgPosition = positions.Average();

        // Round to nearest valid grade
        string averageGrade = gradeScale[(int)Math.Round(avgPosition)];

        Console.WriteLine($"Average Grade of Students: {averageGrade}");


        Console.ReadLine();
    }
}
