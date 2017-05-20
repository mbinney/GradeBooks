using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {

            GradeBook Book = new GradeBook();
            GradeStatistics Stats = new GradeStatistics();

            Book.AddGrades(100);
            Book.AddGrades(50.5f);
            Book.AddGrades(0);

            Stats = Book.ComputeStatistics();
            Console.WriteLine("Average Grade: = " + Stats.AverageGrade);
            Console.WriteLine("Low Grade:" + Stats.LowGrade);
            Console.WriteLine("High Grade:" + Stats.HighGrade);
            Console.ReadLine();
        
        }
    }
}
