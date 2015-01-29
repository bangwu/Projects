using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcApplication1.Controllers;
using System.Net;
using System.Net.Http;
using Xunit;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            FoodTypeController food_type = new FoodTypeController();
            Assert.AreEqual(HttpStatusCode.OK, food_type.index().StatusCode);
        }
    }
}
