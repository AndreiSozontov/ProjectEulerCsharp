using NUnit.Framework;
using EulerProject.Problems;

namespace Tests
{
    public class Problem02
    {
        private readonly ProblemsContainer _problemsContainer = new ProblemsContainer();

        [TestCase(3, ExpectedResult = 2)]
        [TestCase(100, ExpectedResult = 44)]
        [TestCase(4000, ExpectedResult = 3382)]
        public int Problem02_should_return_expected_result(int maxFiblonacciValue)
        {
            // arrange, act, assert
            return _problemsContainer.SolveProblem02(maxFiblonacciValue);
        }
    }
}