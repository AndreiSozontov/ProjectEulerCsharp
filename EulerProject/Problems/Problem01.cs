using System;

namespace EulerProject.Problems
{
    public partial class ProblemsContainer
    {
        /// <summary>
        /// Problem 1.
        /// Find the sum of all the multiples of 3 or 5 below 1000.
        /// </summary>
        public int SolveProblem01(int max = 1000)
        {
            int sum = 0;

            for (int i = 1; i < max; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }
    }
}
