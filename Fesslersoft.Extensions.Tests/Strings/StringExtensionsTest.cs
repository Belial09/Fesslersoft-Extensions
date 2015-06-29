using System;
using System.Text;
using NUnit.Framework;

namespace Fesslersoft.Extensions.Tests.Strings
{
    [TestFixture]
    public class StringExtensionsTest
    {
        [Test]
        public void Test_ReEncodeString()
        {
            String originalString = "Hello This is € Encoding";
            String encodedString = originalString.ChangeEncoding(Encoding.UTF8, Encoding.ASCII);
            Assert.That(encodedString, Is.EqualTo("Hello This is ? Encoding"));
        }
    }
}
