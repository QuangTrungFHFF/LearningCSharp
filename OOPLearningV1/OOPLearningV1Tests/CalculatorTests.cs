using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOPLearningV1;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPLearningV1.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void GetHypotenuseTest()
        {
            //Arrange
            double actualResult;
            double expectedResult = 5;
            var Gethypotenuse = new Calculator();
            //Act
            actualResult = Gethypotenuse.GetHypotenuse(3, 4);
            //Assert
            Assert.AreEqual(expectedResult,actualResult);
        }
    }
}