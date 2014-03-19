using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerSolutions
{
    class Program
    {
        static void Main(string[] args)
        {
            var problemSolver = ProblemStore.Instance.GetProblemSolver(15);

            var result = problemSolver.Solve();

            Console.WriteLine(problemSolver.Title);
            Console.WriteLine(string.Format("Result: {0}", result));

            Console.ReadLine();
        }
    }
}
