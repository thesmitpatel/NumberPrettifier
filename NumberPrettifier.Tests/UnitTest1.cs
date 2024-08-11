using NUnit.Framework;
using NumberPrettifier;

namespace NumberPrettifier.Tests
{
    [TestFixture]
    public class NumberPrettifierTests
    {
        [TestCase(1001, ExpectedResult = "1001")]
        [TestCase(1000000, ExpectedResult = "1M")]
        [TestCase(2500000.34, ExpectedResult = "2.5M")]
        [TestCase(532, ExpectedResult = "532")]
        [TestCase(1123456789, ExpectedResult = "1.1B")]
        [TestCase(1000000000000, ExpectedResult = "1T")]
        public string TestPrettifyNumber(double number)
        {
            return NumberPrettifier.PrettifyNumber(number);
        }
    }
}
