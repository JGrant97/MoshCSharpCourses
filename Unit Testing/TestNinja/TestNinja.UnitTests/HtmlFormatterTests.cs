using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    class HtmlFormatterTests
    {
        [Test]
        public void FormatAsBold_WhenCalled_ShouldEncloseStringWithStrongElement()
        {
            var formatter = new HtmlFormatter();

            var result = formatter.FormatAsBold("abc");

            //Specific
            Assert.That(result, Is.EqualTo("<strong>abc</strong>"));

            //General
            Assert.That(result, Does.StartWith("<strong>"));
            Assert.That(result, Does.Contain("abc"));
            Assert.That(result, Does.EndWith("</strong>"));
        }
    }
}
