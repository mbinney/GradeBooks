using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
   public class GradeStatistics
    {
        public GradeStatistics()
        {

            LowGrade = float.MaxValue;
            HighGrade = 0;
            AverageGrade = 0;

        }

        public float LowGrade;
        public float HighGrade;
        public float AverageGrade;
        
       
    }
}
