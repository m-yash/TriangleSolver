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

        [Test]
        public void ValidIsosceles_Input2and2and3_OutputValidIsosceles()
        {
            int firstSide = 2;
            int secondSide = 2;
            int thirdSide = 3;

            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual("An isosceles triangle is formed", result);
        }

        [Test]
        public void ValidIsosceles_Input3and2and2_OutputValidIsosceles()
        {
            // Arrange
            int firstSide = 3;
            int secondSide = 2;
            int thirdSide = 2;

            // Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual("An isosceles triangle is formed", result);
        }

        [Test]
        public void ValidIsosceles_Input2and3and2_OutputValidIsosceles()
        {
            // Arrange
            int firstSide = 2;
            int secondSide = 3;
            int thirdSide = 2;

            // Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual("An isosceles triangle is formed", result);
        }
    }
}
