using System;
using EulerSolutions.Common;
using EulerSolutions.Problems;

namespace EulerSolutions
{
    internal class Program
    {
        public static void Main()
        {
            int problemId;

            do
            {
                Console.WriteLine("Enter Problem Number:");
            } while (!int.TryParse(Console.ReadLine(), out problemId));

            Result result = Execute(problemId);

            PublishResult(result);

            Console.ReadLine();
        }

        private static Result Execute(int problemId)
        {
            var problemSolver = ProblemStore.Instance.Get<IProblemSolver<string>>(problemId);

            IActionRunner runner = new ActionRunner();
            var answer = runner.Invoke<string>(problemSolver.Solve);

            return new Result(problemSolver.Title, answer, runner.TimeElapsed);
        }

        private static void PublishResult(Result result)
        {
            Console.WriteLine(result.Title);
            Console.WriteLine("Answer: {0}", result.Answer);
            Console.WriteLine("Time Taken: {0}",
                string.Format("{0:D2}h:{1:D2}m:{2:D2}s:{3:D3}ms",
                    result.TimeElapsed.Hours,
                    result.TimeElapsed.Minutes,
                    result.TimeElapsed.Seconds,
                    result.TimeElapsed.Milliseconds));
        }

        private struct Result
        {
            public readonly string Answer;
            public readonly TimeSpan TimeElapsed;
            public readonly string Title;

            public Result(string title, string answer, TimeSpan timeElapsed)
            {
                Title = title;
                Answer = answer;
                TimeElapsed = timeElapsed;
            }
        }
    }
}