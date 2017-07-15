using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeBook
    {
        private List<float> Grades;
        private string _name;
        public event NameChangedDelegate NameChanged;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    if (_name != value)
                    {

                        NameChangedEventArgs args = new NameChangedEventArgs();
                        args.ExistingName = _name;
                        args.NewName = value;                                                
                        NameChanged(this, args);
                    }
                    _name = value;
                }
            }
        }

        public GradeBook()
        {
            _name = "Empty";
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

        internal void WriteGrades(TextWriter destination)
        {
            for (int i = 0; i < Grades.Count; i++)
            {
                destination.WriteLine(Grades[i]);
            }
        }
    }
}
