using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Test.Types
{
    [TestClass]
    public class ReferenceAndValueTypeTests
    {

        [TestMethod]
        public void ValueTypesPassByValue()
        {
            Int32 x = 46;
            IncrementNumber(x);

            Assert.AreEqual(46, x);            

        }

        private void IncrementNumber(Int32 number)
        {
            number += 1;
        }

        [TestMethod]
        public void VariablesHoldsReference()
        {

            GradeBook gb1 = new GradeBook();
            GradeBook gb2 = gb1;

            gb1.Name = "Scott's grade book";
            Assert.AreEqual(gb1, gb2);                       

        }

        [TestMethod]
        public void ReferenceTypesPassByValue()
        {

            GradeBook book1 = new GradeBook();
            GradeBook book2 = book1;

            GiveBookAName(book2);

            Assert.AreEqual("A GradeBook", book1.Name);


        }

        private void GiveBookAName(GradeBook Book)
        {

            Book.Name = "A GradeBook";

        }

        [TestMethod]
        public void IntVariablesHoldValue()
        {
            int x1 = 100;
            int x2 = x1;

            x1 = 4;

            Assert.AreNotEqual(x1, x2);

        }

        [TestMethod]
        public void StringComparisons()
        {
            string name1 = "Scott";
            string name2 = "scott";

            bool result = string.Equals(name1,name2, StringComparison.InvariantCultureIgnoreCase);

            Assert.IsTrue(result);

        }
    }
}
