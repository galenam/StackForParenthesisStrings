using NUnit.Framework;
using StackNodeParenthesis.Project;

namespace StackNodeParenthesis.Tests
{
    public class TestParenthesis
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(null, ExpectedResult = true)]
        [TestCase("", ExpectedResult = true)]
        [TestCase("[(){}]{()()}", ExpectedResult = true)]
        [TestCase("[(])", ExpectedResult = false)]
        [TestCase("{", ExpectedResult = false)]
        [TestCase("]", ExpectedResult = false)]
        public bool TestString(string source)
        {
            return StackParenthesis.Analize(source);
        }
    }
}