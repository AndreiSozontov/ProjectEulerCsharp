using System;

namespace EulerProject.Problems
{
    public partial class ProblemsContainer
    {
        /// <summary>
        /// The prime factors of 13195 are 5, 7, 13 and 29.
        /// What is the largest prime factor of the number 600851475143 ?
        /// </summary>
        /// <returns>Largest prime factor of the number</returns>
        public int SolveProblem03(long number = 600851475143)
        {
            // Our number isn't quite big - only 12 digits, so we won't use any kind of serious factorization algorythms,
            // In more we're gonna find the largest one and then break
            int largestPrimeFactor = 1;

            for (int i = (int)(Math.Sqrt(number) + 1); i > 0; i--)
            {
                if (number % i == 0 && IsPrimeNumber(i))
                {
                    largestPrimeFactor = i;
                    break;
                }
            }

            return largestPrimeFactor;
        }

        /// <summary>
        /// A number is Prime if it has no factors except 1 and itself.
        /// Method checks, if the number is Prime.
        /// </summary>
        private bool IsPrimeNumber(int number)
        {
            if (number == 1 || number == 2)
                return true;

            for (long i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }
    }
}
