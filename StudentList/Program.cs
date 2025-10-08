using System;
using System.Xml;
using StudentList;

class Program
{
    static void Main(string[] args)
    {
        var students = new List<Student>
        {
            new Student(name: "Ram Hari", age: 17, grade: "A+", major: "Science"),
            new Student(name: "Kiran Niraula", age: 18, grade: "A", major: "Science"),
            new Student(name: "Shree Sundari", age: 17, grade: "A", major: "Management"),
            new Student(name: "Aman Gurung", age: 18, grade: "B+", major: "Law"),
            new Student(name: "Maiya Shakya", age: 17, grade: "A", major: "Humanities"),
            new Student(name: "Shyam Maharjan", age: 16, grade: "B", major: "Management")
        };

        //----| filter students by grade|----

        var studentWithGradeA = (from student in students
                                where student.Grade == "A"
                                select student).ToList();
        //var StudentWithGradeA = students.Where(student => student.Grade == "A").ToList();

        foreach(var student in studentWithGradeA)
        {
            Console.WriteLine(student.Name);
        }

        Console.WriteLine();

        //----| sort students by age |----

        var studentAgeSortedInAscendingOrder = (from student in students
                               orderby student.Age ascending
                               select student).ToList();

        //var StudentAgeSortedInDescendingOrder = students.OrderByDescending(student => student.Age).ToList();

        foreach(var student in studentAgeSortedInAscendingOrder)
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


        //---| average grade |---

        var gradeScale = new Dictionary<string, double>
        {
            { "A+", 4.0 },
            { "A", 3.6 },
            { "B+", 3.2 },
            { "B", 2.8 },
            { "C+", 2.4 },
            { "C", 2.0 },
            { "D", 1.6 },
            { "F", 0.0 }
        };

        // Calculate average GPA
        double averageGpa = students.Average(student => gradeScale[student.Grade]);

        Console.WriteLine($"Average Grade (GPA): {averageGpa:F2}");

        Console.ReadLine();
    }
}
