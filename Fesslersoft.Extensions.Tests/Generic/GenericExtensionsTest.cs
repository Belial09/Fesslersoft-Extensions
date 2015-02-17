using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Fesslersoft.Extensions.Tests.Generic
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void TestA()
        {
            var varA = new decimal(100.00);
            var varB = (Int64) 1000;
            var varC = (short) 150;
            var varD = (Double) 10.10;


            Assert.That(varB.IsLargerThan(varA));
            Assert.That(varC.IsLargerThan(varA));
            Assert.That(!varD.IsLargerThan(varA));

            Assert.That(!varA.IsLargerThan(varB));
            Assert.That(!varC.IsLargerThan(varB));
            Assert.That(!varD.IsLargerThan(varB));

            Assert.That(varB.IsLargerThan(varC));
            Assert.That(!varA.IsLargerThan(varC));
            Assert.That(!varD.IsLargerThan(varC));

            Assert.That(varB.IsLargerThan(varD));
            Assert.That(varC.IsLargerThan(varD));
            Assert.That(varA.IsLargerThan(varD));
        }
    }
}
