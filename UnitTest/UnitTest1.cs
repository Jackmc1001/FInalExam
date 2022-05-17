using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FinalExam;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //ARRANGE
            RentalProperty r1 = new RentalProperty() { ID = 1, Price = 1000 };

            //ACT
            r1.IncreaseRent( 0.25m);

            //ASSERT
            Assert.AreEqual(1250m, r1.Price);
        }
        [TestMethod]
        public void TestMethod2()
        {
            RentalProperty r2 = new RentalProperty() { ID = 2, Price = 10000m };

            //ACT
            r2.IncreaseRent(0.25m);

            //ASSERT
            Assert.AreEqual(12500m, r2.Price);
        }
    }
}
