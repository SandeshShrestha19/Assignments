using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentGradeManagementSystem
{
    public class Student
    {
        public double[] Grades { get; set; }

        /// <summary>
        /// This method helps to collect the grades of multiple student and store those data in an array
        /// </summary>
        public double[] CollectGrades()
        {
            Console.Write("How many grades do you want to enter? ");
            var numberOfGrades = Convert.ToInt32(Console.ReadLine());

            Grades = new double[numberOfGrades];

            for (var i = 0; i < numberOfGrades; i++)
            {
                Console.Write($"Enter grade #{i + 1}: ");
                Grades[i] = Convert.ToDouble(Console.ReadLine());
            }
            return Grades;
        }
        /// <summary>
        /// This method helps to calculate the average of the grades collected in an array
        /// </summary>
        public string GetAverage()
        {
            if (Grades == null || Grades.Length == 0)
            {
                return "No grades were entered!";
            }

            var averageGrades = Grades.Average();
            return $"The average of grades is {averageGrades:F2}.";
        }
        /// <summary>
        /// This method displays the grades obtained by respective student.
        /// </summary>
        public void DisplayReports()
        {
            Console.WriteLine("|----Reports----|");

            Console.WriteLine();

            for (var i = 0;i < Grades.Length; i++)
            {
                Console.WriteLine($"Student {i+1} received grade: {Grades[i]:F2}.");
            }
        }
    }
}

