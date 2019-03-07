using System;
using NUnit.Framework;

namespace JDI_Light_Template.Tests.Example
{
    public class RetryTests : SimpleTestsInit
    {
        private int _count = 0;

        [Test]
        public void FailedTest1()
        {
            Console.WriteLine("Retry1: " + _count);
            if (_count++ % 2 == 0)
            {
                Assert.IsTrue(false);
            }
        }

        [Test]
        public void FailedTest2()
        {
            Console.WriteLine("Retry2: " + _count);
            Assert.IsTrue(false);
        }
    }
}
