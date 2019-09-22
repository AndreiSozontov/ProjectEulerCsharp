using System;
using EulerProject.Problems;

namespace EulerProject
{
    class Program
    {
        static void Main()
        {
            var container = new ProblemsContainer();
            Console.WriteLine($"Problem 1 solution is {container.SolveProblem01()}");
            Console.WriteLine($"Problem 2 solution is {container.SolveProblem02()}");
            Console.WriteLine($"Problem 3 solution is {container.SolveProblem03()}");
            Console.ReadKey();
        }
    }
}
