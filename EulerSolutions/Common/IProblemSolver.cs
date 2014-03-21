namespace EulerSolutions.Common
{
    public interface IProblemSolver<out TResult>
    {
        /// <summary>
        /// Represents the title of the problem
        /// </summary>
        string Title { get; }

        /// <summary>
        /// This is the definition of the problem
        /// </summary>
        string Definition { get; }

        /// <summary>
        /// Method that is responsible for solving the problem
        /// </summary>
        /// <returns>Returns the result value</returns>
        TResult Solve();
    }
}