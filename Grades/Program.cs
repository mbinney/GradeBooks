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

            //Book.NameChanged += new NameChangedDelegate(OnNameChanged); // overwritten with OnNameChanged2 except with +=
            //Book.NameChanged += new NameChangedDelegate(OnNameChanged2); // event keyword not = only +=
            //Book.NameChanged = null; //don't use

            //Book.NameChanged += OnNameChanged; //automatically create the delegate instance behind the scene will know it is a NameChangedDelegate
            //Book.NameChanged += OnNameChanged2; //automatically create the delegate instance behind the scene will know it is a NameChangedDelegate
            //Book.NameChanged += OnNameChanged2;
            //Book.NameChanged -= OnNameChanged2; //will subscribe twice and remove once -= unscubscribe

            Book.NameChanged += OnNameChanged; // Subscribe to event.

            Book.Name = "Scott's Grade Book"; 
            Book.Name = "Grade Book";
            Book.AddGrades(100);
            Book.AddGrades(50.5f);
            Book.AddGrades(75);
            Book.WriteGrades(Console.Out);

            Stats = Book.ComputeStatistics();
            Console.WriteLine(Book.Name);
            WriteResult("Average", Stats.AverageGrade);
            WriteResult("Low", Stats.LowGrade);
            WriteResult("High", (int)Stats.HighGrade); //float will be truncated not rounded.
            WriteResult("", Stats.LetterGrade);
            Console.ReadLine();

        }

        static void WriteResult(string description, string result)
        {
            Console.WriteLine(description + ":: " + result);
        }

        static void WriteResult(string description, int result)
        {
            Console.WriteLine(description + ":: " + result);
        }

        static void WriteResult(string description, float result)
        {
            Console.WriteLine("{0}: {1}", description, result);
        }

        static void OnNameChanged(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine($"Grade book changing name from {args.ExistingName} to {args.NewName}");
        }

        /*static void OnNameChanged2(string existingName, string newName)
        {
            Console.WriteLine("***");
        }*/


    }
}
