﻿using System;
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

        public string LetterGrade
        {

            get
            {
                string result;
                if (AverageGrade >= 90)
                {
                    result = "A";
                }
                else if (AverageGrade >= 80)
                {
                    result = "B";
                }
                else if (AverageGrade >= 70)
                {
                    result = "C";
                }
                else if (AverageGrade >= 60)
                {
                    result = "D";
                }
                else
                {
                    result = "F";
                }
            

                return result;

            }
        }

        public float LowGrade;
        public float HighGrade;
        public float AverageGrade;
        
       
    }
}
