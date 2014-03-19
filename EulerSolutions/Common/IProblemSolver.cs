namespace EulerSolutions.Common
{
    public interface IProblemSolver
    {
        /// <summary>
        /// Represents the title of the problem
        /// </summary>
        string Title { get; }

        /// <summary>
        /// This is the definition of the problem
        /// </summary>
        string Definition { get; }

        string Solve();
    }
}