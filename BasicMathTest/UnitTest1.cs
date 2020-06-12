using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestPractice;

namespace BasicMathTest
{
    [TestClass]
    public class UnitTest1
    {
        //test the happy path for Add Method in Basic Math class
        [TestMethod]
       public void TestAddMethod_Correct()
        {
            BasicMaths bm = new BasicMaths(); //instance of the basic maths class - contains units(methods) to test
            double result = bm.AddNums(15, 10);
            Assert.AreEqual(result, 25); // checks if the test data matches what the answer should be
        }

        [TestMethod]
        public void TestSubMethod_Correct()
        {
            BasicMaths bm = new BasicMaths();
            double result = bm.SubNums(15, 10);
            Assert.AreEqual(result, 5);
        }

        [TestMethod]
        public void TestMultMethod_Correct()
        {
            BasicMaths bm = new BasicMaths();
            double result = bm.MultNum(10, 5);
            Assert.AreEqual(result, 50);
        }

        [TestMethod]
        public void TestDivMethod_Correct()
        {
            BasicMaths bm = new BasicMaths();
            double result = bm.DivNum(10, 2);
            Assert.AreEqual(result, 5);
        }
    }
}
