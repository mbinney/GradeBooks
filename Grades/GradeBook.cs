using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeBook : GradeTracker
    {
        protected List<float> Grades; //inherited -- protected keyword -- from derived class or this class only
               
        public GradeBook()
        {
            _name = "Empty";
            Grades = new List<float>();        
        }

        public override void AddGrade(float grade)
        {
            Grades.Add(grade);
        }

        public override GradeStatistics ComputeStatistics() //base clase has virtual and dirived class has override
        {

            Console.WriteLine("Gradebook::ComputeStatistics");

            GradeStatistics Stats = new GradeStatistics();

            float sum = 0;
            foreach (float grade in Grades)
            {
                Stats.LowGrade = Math.Min(grade, Stats.LowGrade);
                Stats.HighGrade = Math.Max(grade, Stats.HighGrade);
                sum += grade;
            }

            Stats.AverageGrade = sum / Grades.Count;

            return Stats;

        }

        public override IEnumerator GetEnumerator()
        {
            return base.GetEnumerator();
        }

        public override void WriteGrades(TextWriter destination)
        {
            for (int i = 0; i < Grades.Count; i++)
            {
                destination.WriteLine(Grades[i]);
            }
        }
    }
}
