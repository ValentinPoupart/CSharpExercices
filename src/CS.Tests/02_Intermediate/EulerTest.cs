using CS.Impl._02_Intermediate;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CS.Tests._02_Intermediate
{
    [TestClass]
    public class EulerTest
    {
        [TestMethod]
        public void EulerTestSmallest_EvenlyDivisible_ByNumber_From_1to10()
        {
            var euler = new Euler();

            var result = euler.SmallestMultiple(10, 10);

            Assert.AreEqual(2520, result);
        }

        [TestMethod]
        public void EulerTestSmallest_EvenlyDivisible_ByNumber_From_1to20()
        {
            var euler = new Euler();

            var result = euler.SmallestMultiple(20, 20);

            Assert.AreEqual(232792560, result);
        }

        [TestMethod]
        public void EulerTestSmallest_EvenlyDivisible_ByNumber_From_1to11()
        {
            var euler = new Euler();

            var result = euler.SmallestMultiple(11, 11);

            Assert.AreEqual(27720, result);
        }

    }
}
