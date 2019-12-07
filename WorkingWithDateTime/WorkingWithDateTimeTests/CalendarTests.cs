using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace WorkingWithDateTime.Tests
{
    [TestClass()]
    public class CalendarTests
    {
        [TestMethod]
        public void CalcGoodFridayTest()
        {
            //Arrange
            DateTime expectedTime = new DateTime(2019, 04, 19);
            DateTimeOffset expectedDate = new DateTimeOffset(expectedTime, TimeZoneInfo.Local.GetUtcOffset(expectedTime));

            //Act
            var result = Calendar.CalcGoodFriday(2019);
            //Assert

            Assert.AreEqual(expectedDate, result);
        }
    }
}