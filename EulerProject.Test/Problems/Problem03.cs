using NUnit.Framework;
using EulerProject.Problems;

namespace Tests
{
    public class Problem03
    {
        private readonly ProblemsContainer _problemsContainer = new ProblemsContainer();

        [TestCase(13195, ExpectedResult = 29)]
        [TestCase(600851475143, ExpectedResult = 6857)]
        public int Problem03_should_return_expected_result(long number)
        {
            // arrange, act, assert
            return _problemsContainer.SolveProblem03(number);
        }
    }
}