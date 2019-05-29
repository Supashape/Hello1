using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hello;
namespace helloTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("Hell World", Program.createMessage());
        }
    }
}
