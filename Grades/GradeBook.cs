using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeBook
    {

        public List<float> Grades;

        public string Name;

        public GradeBook()
        {
            Grades = new List<float>();        
        }

        public void AddGrades(float grade)
        {
            Grades.Add(grade);
        }

        public GradeStatistics ComputeStatistics()
        {

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

    }
}
