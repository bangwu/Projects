using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcApplication1.Controllers;
using System.Net;
using System.Net.Http;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            FoodController foodController = new FoodController();
            Assert.AreEqual(HttpStatusCode.OK, foodController.get().StatusCode);
        }
    }
}
