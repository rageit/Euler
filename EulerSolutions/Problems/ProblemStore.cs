using System;
using System.Collections.Generic;
using EulerSolutions.Common;

namespace EulerSolutions.Problems
{
    public class ProblemStore
    {
        // Just working with strings at the moment
        private readonly Dictionary<int, object> _store = new Dictionary<int, object>();

        private static readonly Lazy<ProblemStore> Lazy = new Lazy<ProblemStore>(() => new ProblemStore());

        public static ProblemStore Instance
        {
            get { return Lazy.Value; }
        }

        private ProblemStore()
        {
            Add(15, new Problem15());
            Add(17, new Problem17());
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