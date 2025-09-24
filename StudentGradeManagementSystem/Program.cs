using StudentGradeManagementSystem;
using System;

class Program
{
    static void Main(string[] args)
    {
        var student = new Student();

        student.GetGrades();

        student.GetAverage();
        
        student.DisplayReports();

        Console.ReadLine();
    }
}



