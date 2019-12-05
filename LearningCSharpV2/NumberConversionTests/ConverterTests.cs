using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NumberConversionV2.Tests
{
    [TestClass()]
    public class ConverterTests
    {
        [TestMethod()]
        public void GetDigitArrayTest()
        {
            //Arrange
            int[] actualArray = new int[10];
            int[] expectedArray = new int[10];
            expectedArray[0] = 7;
            expectedArray[1] = 3;
            expectedArray[2] = 1;
            var digitArrayCheck = new Converter();

            //Act
            actualArray = digitArrayCheck.GetDigitArray(137);

            //Assert
            CollectionAssert.AreEqual(expectedArray, actualArray);
        }

        [TestMethod()]
        public void ParseStringToDigitArrayTest()
        {
            //Arrange
            //int[] actualArray = new int[3];
            int[] expectedArray = new int[3];
            expectedArray[0] = 7;
            expectedArray[1] = 3;
            expectedArray[2] = 1;
            var digitArrayCheck = new Converter();
            //Act
            int[] actualArray = digitArrayCheck.ParseStringToDigitArray("137");

            //Assert
            CollectionAssert.AreEqual(expectedArray, actualArray);
        }

        [TestMethod()]
        public void GetSumOfDigitArrayTest()
        {
            //Arrange
            int[] firstArray = { 9, 8, 7 };
            int[] secondArray = { 7, 8, 9 };
            int[] expectedArray = { 6, 7, 7, 1 };
            var sumOfDigitalArraycheck = new Converter();
            //Act
            int[] actualArray = sumOfDigitalArraycheck.GetSumOfDigitArray(firstArray, secondArray);

            //Assert
            CollectionAssert.AreEqual(expectedArray, actualArray);
        }

        [TestMethod()]
        public void GetMaxElementInRangeTest()
        {
            //Arrange
            int[] numArray = { 6, 7, 8, 1, 9, 2, 4 };
            int expectedResult = 9;
            var maxElementCheck = new Converter();
            //Act
            int actualResult = maxElementCheck.GetMaxElementInRange(numArray, 0, 7);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod()]
        public void SortArrayTest()
        {
            //Arrange
            int[] numArray = { 6, 7, 8, 1, 9, 2, 4 };
            int[] expectedResult = { 9, 8, 7, 6, 4, 2, 1 };
            var sortArrayCheck = new Converter();
            //Act
            int[] actualResult = sortArrayCheck.SortArray(numArray);
            //Assert
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }
    }
}