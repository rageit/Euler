using System;
using System.Collections.Generic;

namespace EulerSolutions.Problems
{
    public class ProblemStore
    {
        // Just working with strings at the moment

        private static readonly Lazy<ProblemStore> Lazy = new Lazy<ProblemStore>(() => new ProblemStore());
        private readonly Dictionary<int, object> _store = new Dictionary<int, object>();

        private ProblemStore()
        {
            Add(15, new Problem15());
            Add(17, new Problem17());
            Add(18, new Problem18());
            Add(19, new Problem19());
            Add(21, new Problem21());
            Add(22, new Problem22());
            Add(23, new Problem23());
            Add(24, new Problem24());
        }

        public static ProblemStore Instance
        {
            get { return Lazy.Value; }
        }

        private void Add(int problemNumber, object problemSolver)
        {
            _store.Add(problemNumber, problemSolver);
        }

        public TType Get<TType>(int problemNumber)
        {
            if (!(_store[problemNumber] is TType))
                throw new Exception("Invalid Problem Solver Type.");

            return (TType) _store[problemNumber];
        }
    }
}