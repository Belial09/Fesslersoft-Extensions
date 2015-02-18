using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Fesslersoft.Extensions.Tests.Generic
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void Test_IsLargerThan_Int32_Int32_B_GreaterThan_A()
        {
            Int32 valueA = 10;
            Int32 valueB = 20;

            Assert.That(!valueA.IsLargerThan(valueB));
        }

        [Test]
        public void Test_IsLargerThan_Int32_Int32_A_GreaterThan_B()
        {
            Int32 valueB = 10;
            Int32 valueA = 20;

            Assert.That(valueA.IsLargerThan(valueB));
        }

        [Test]
        public void Test_IsLargerThan_Int32_Int32_A_Equals_B()
        {
            Int32 valueB = 10;
            Int32 valueA = 10;

            Assert.That(!valueA.IsLargerThan(valueB));
        }

        [Test]
        public void Test_IsLargerThan_Int16_Int16_B_GreaterThan_A()
        {
            Int16 valueA = 10;
            Int16 valueB = 20;

            Assert.That(!valueA.IsLargerThan(valueB));
        }

        [Test]
        public void Test_IsLargerThan_Int16_Int16_A_GreaterThan_B()
        {
            Int16 valueB = 10;
            Int16 valueA = 20;

            Assert.That(valueA.IsLargerThan(valueB));
        }

        [Test]
        public void Test_IsLargerThan_Int16_Int16_A_Equals_B()
        {
            Int16 valueB = 10;
            Int16 valueA = 10;

            Assert.That(!valueA.IsLargerThan(valueB));
        }

        [Test]
        public void Test_IsLargerThan_Int64_Int64_B_GreaterThan_A()
        {
            Int64 valueA = 10;
            Int64 valueB = 20;

            Assert.That(!valueA.IsLargerThan(valueB));
        }

        [Test]
        public void Test_IsLargerThan_Int64_Int64_A_GreaterThan_B()
        {
            Int64 valueB = 10;
            Int64 valueA = 20;

            Assert.That(valueA.IsLargerThan(valueB));
        }

        [Test]
        public void Test_IsLargerThan_Int64_Int64_A_Equals_B()
        {
            Int64 valueB = 10;
            Int64 valueA = 10;

            Assert.That(!valueA.IsLargerThan(valueB));
        }

        [Test]
        public void Test_IsLargerThan_Double_Double_B_GreaterThan_A()
        {
            Double valueA = 10.10;
            Double valueB = 20.20;

            Assert.That(!valueA.IsLargerThan(valueB));
        }

        [Test]
        public void Test_IsLargerThan_Double_Double_A_GreaterThan_B()
        {
            Double valueB = 10.10;
            Double valueA = 20.20;

            Assert.That(valueA.IsLargerThan(valueB));
        }

        [Test]
        public void Test_IsLargerThan_Double_Double_A_Equals_B()
        {
            Double valueB = 10.00;
            Double valueA = 10.00;

            Assert.That(!valueA.IsLargerThan(valueB));
        }

    }
}
