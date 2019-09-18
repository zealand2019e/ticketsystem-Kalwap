using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace TicketLibararyTest
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Testing all the methods inside the specific classess
        /// </summary>
        [TestMethod]
        public void TestLicencePlate()
        {
            //Add
            TicketLibrary.Car car = new TicketLibrary.Car();
            //Act
            double actualPrice = car.Price();
            //Assert
            Assert.AreEqual(240, actualPrice);
        }

        [TestMethod]
        public void TestVehicleType()
        {
            //add
            TicketLibrary.Car car = new TicketLibrary.Car();

            //act
            string actualType = car.VehicleType();
            //assert
            Assert.AreEqual("Car", actualType);
        }

        [TestMethod]

        public void TestPriceMC()
        {
            //add 
            TicketLibrary.MC mc = new TicketLibrary.MC();
            //act
            double actualPrice = mc.Price();
            //asssert
            Assert.AreEqual(125, actualPrice);

        }

        [TestMethod]

        public void TestTypeMC()
        {
            //add
            TicketLibrary.MC mc = new TicketLibrary.MC();
            //act
            string actualName = mc.Vehicle();
            //assert 
            Assert.AreEqual("MC",actualName);
        }

    }
}
