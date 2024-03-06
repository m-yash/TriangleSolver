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

        [Test]
        public void ValidScalene_Input15and16and17_OutputValidScalene()
        {
            // Arrange
            int side1 = 3;
            int side2 = 4;
            int side3 = 5;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual("A scalene triangle is formed", result);
        }

        [Test]
        public void ValidScalene_Input18and19and20_OutputValidScalene()
        {
            // Arrange
            int side1 = 5;
            int side2 = 12;
            int side3 = 13;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual("A scalene triangle is formed", result);
        }

        [Test]
        public void ValidScalene_Input21and22and23_OutputValidScalene()
        {
            // Arrange
            int side1 = 8;
            int side2 = 15;
            int side3 = 17;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual("A scalene triangle is formed", result);
        }

        [Test]
        public void ValidScalene_Input24and25and26_OutputValidScalene()
        {
            // Arrange
            int side1 = 7;
            int side2 = 10;
            int side3 = 12;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual("A scalene triangle is formed", result);
        }

        [Test]
        public void ValidScalene_Input28and28and29_OutputValidScalene()
        {
            // Arrange
            int side1 = 9;
            int side2 = 12;
            int side3 = 15;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual("A scalene triangle is formed", result);
        }

    }
}
