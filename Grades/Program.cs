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
            WriteResult("Average", Stats.AverageGrade);
            WriteResult("Low", Stats.AverageGrade);
            WriteResult("High", (int)Stats.AverageGrade);
            Console.ReadLine();

        }

        static void WriteResult(string description, int result)
        {
            Console.WriteLine(description + ":: " + result);
        }

        static void WriteResult(string description, float result)
        {
            Console.WriteLine("{0}: {1}", description, result);
        }

    }
}
