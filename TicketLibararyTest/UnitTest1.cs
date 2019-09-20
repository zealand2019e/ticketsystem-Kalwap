using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TicketLibrary;


namespace TicketLibararyTest
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Testing all the methods inside the specific classess
        /// </summary>
        [TestMethod]
        public void TestPriceCar()
        {
            //Arrange
            double expectedResult = 240;

            // Act
            Car car = new Car("");


            //Asser
            Assert.AreEqual(expectedResult, car.Price);
        }

        [TestMethod]

        public void TestVehicleType()
        {
            Car car = new Car("");

            string actualtype = car.licensePlate;

            Assert.AreEqual("Car", actualtype);

        }
    }
}
