using System;
using AssesementIOne;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Unit_Test
{
    [TestClass]
    public class UnitTest1
    {
        Form1 form1 = new Form1(); // check the test method
        private string actual;
        private object myForm1;
        mmclass tmmclass = new mmclass();

        [TestMethod]
        public void TestConditionWin()
        {
            int actual = tmmclass.spin();
            Assert.IsTrue(actual <= 5);
        }
        [TestMethod]
        public void BulletSkip()
        {
            var Actual = tmmclass.Skip();
            Assert.AreEqual("Skipped", actual);
        }
    }
}
