using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class ThrowAwayGradeBook : GradeBook
    {

        public override GradeStatistics ComputeStatistics() //overide and virtual for inheritance.
        {

            Console.WriteLine("ThrowAwayGradeBook::ComputeStatistics");
            float lowest = float.MaxValue;
            foreach (float grade in Grades)
            {
                lowest = Math.Min(grade, lowest);
            }            
            Grades.Remove(lowest);
            return base.ComputeStatistics();
        }
    }
}
