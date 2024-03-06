using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TriangleSolver;//


namespace TriangleTest
{
    [TestFixture]
    public class TriangleTest1
    {
        [Test]
        public void ValidEquilateral_Input60and60and60_OutputValidEquilateral()
        {
            int firstSide = 1;
            int secondSide = 1;
            int thirdSide = 1;

            string expected = "An equilateral triangle is formed";

            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            Assert.AreEqual(expected, result);
        }
    }
}
