using System.Text.RegularExpressions;
using FluentAssertions;

namespace Tests
{
    public class Tests
    {
        private readonly string pattern = @"(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[!""#$%&'()*+,-./:;<=>?@[\]^_`{|}~])^(?=.{1,10}$).*^[^\s\t\n]+$";

        [Test]
        public void InputIsValid()
        {
            string input = "Aa!1";

            Regex reg = new Regex(pattern);
            var result = reg.IsMatch(input);

            result.Should().Be(true);
        }

        [Test]
        [TestCase("")]
        [TestCase("abc")]
        [TestCase("ABC")]
        [TestCase("Ab")]
        [TestCase("Ab!")]
        [TestCase("Ab2")]
        [TestCase("aa!1")]
        [TestCase("AA!1")]
        [TestCase("Aa!2bcdefghi")]
        [TestCase("Aa!2 ")]
        [TestCase("Aa!2    ")]
        public void InputIsNotValid(string input)
        {
            Regex reg = new Regex(pattern);
            var result = reg.IsMatch(input);

            result.Should().Be(false);
        }
    }
}