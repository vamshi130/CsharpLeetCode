using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalcualationTest
{
    [TestClass]
    public class CalculationTest
    {
        [TestMethod]
        public void TestDivide()
        {
            //Arrange
            int expected = 4;
            int numerator = 20;
            int denominator = 5;
            //Act
           int actual= Calculation.Program.Divide(numerator,denominator);
            //Assert
           
            Assert.AreEqual(expected, actual);


        }

    }
}
