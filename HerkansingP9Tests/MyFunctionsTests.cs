using Microsoft.VisualStudio.TestTools.UnitTesting;
using HerkansingP9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerkansingP9.Tests
{
    [TestClass()]
    public class MyFunctionsTests
    {
        [TestMethod()]
        public void SumTest()
        {
            int sum = MyFunctions.Sum(4, 5);
            Assert.AreEqual(9,sum);
        }
    }
}