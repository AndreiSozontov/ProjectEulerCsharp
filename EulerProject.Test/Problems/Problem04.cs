using NUnit.Framework;
using EulerProject.Problems;

namespace Tests
{
    public class Problem04
    {
        private readonly ProblemsContainer _problemsContainer = new ProblemsContainer();

        [Test]
        public void Problem04_should_return_expected_result()
        {
            // arrange, act
            var actualResult = _problemsContainer.SolveProblem04();
            // assert
            Assert.AreEqual(906609, actualResult);
        }
    }
}