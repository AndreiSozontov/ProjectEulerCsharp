using NUnit.Framework;
using EulerProject.Problems;

namespace Tests
{
    public class Problem01
    {
        private readonly ProblemsContainer _problemsContainer = new ProblemsContainer();

        [TestCase(4, ExpectedResult = 3)]
        [TestCase(10, ExpectedResult = 23)]
        [TestCase(14, ExpectedResult = 45)]
        [TestCase(1000, ExpectedResult = 233168)]
        public int Problem01_should_return_expected_result(int max)
        {
            // arrange, act, assert
            return _problemsContainer.SolveProblem01(max);
        }
    }
}