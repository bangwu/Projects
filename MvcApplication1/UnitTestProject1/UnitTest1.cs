using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcApplication1.Controllers;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            FoodController foodController = new FoodController();
            //Assert.AreEqual("nihao", foodController.get());
        }
    }
}
