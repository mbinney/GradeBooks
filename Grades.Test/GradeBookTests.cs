using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Grades;

namespace Grades.Test
{
    [TestClass]
    public class GradeBookTests
    {
        [TestMethod]
        public void ComputeHighestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrades(10);
            book.AddGrades(90);

            GradeStatistics stats =  book.ComputeStatistics();
            Assert.AreEqual(stats.HighGrade, 90);
        }

        [TestMethod]
        public void ComputeLowestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrades(10);
            book.AddGrades(90);

            GradeStatistics stats = book.ComputeStatistics();
            Assert.AreEqual(stats.LowGrade, 10);
        }

        [TestMethod]
        public void ComputeAverageGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrades(10);
            book.AddGrades(90);

            GradeStatistics stats = book.ComputeStatistics();
            Assert.AreEqual(stats.AverageGrade, 50);
        }

    }
}
