using System;
using System.Collections.Generic;
using EulerSolutions.Common;
using EulerSolutions.Problems;

namespace EulerSolutions
{
    public class ProblemStore
    {
        private readonly Dictionary<int, IProblemSolver> _store = new Dictionary<int, IProblemSolver>();

        private static readonly Lazy<ProblemStore> Lazy = new Lazy<ProblemStore>(() => new ProblemStore());

        public static ProblemStore Instance
        {
            get { return Lazy.Value; }
        }

        private ProblemStore()
        {
            Add(15, new Problem15());
        }

        private void Add(int problemNumber, IProblemSolver toStore)
        {
            _store.Add(problemNumber, toStore);
        }

        public IProblemSolver GetProblemSolver(int problemNumber)
        {
            return _store[problemNumber];
        }
    }
}