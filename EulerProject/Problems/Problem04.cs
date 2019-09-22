using System;
using System.Linq;

namespace EulerProject.Problems
{
    public partial class ProblemsContainer
    {
        /// <summary>
        /// A palindromic number reads the same both ways.
        /// The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
        /// Find the largest palindrome made from the product of two 3-digit numbers.
        /// </summary>
        public int SolveProblem04()
        {
            var maxPalindrome = 0;

            for (int i = 100; i <= 999; i++)
            {
                for (int j = 100; j <= 999; j++)
                {
                    var temp = i * j;

                    if (IsPalindrome(temp) && temp > maxPalindrome)
                    {
                        maxPalindrome = temp;
                    }
                }
            }

            return maxPalindrome;
        }

        private bool IsPalindrome(int number)
        {
            var stringNumber = number.ToString();
            var reversed = new string(stringNumber.Reverse().ToArray());

            return reversed.Equals(stringNumber, StringComparison.InvariantCulture);
        }
    }
}
