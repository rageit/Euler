using System;

namespace EulerSolutions.Common
{
    public interface IActionRunner
    {
        TimeSpan TimeElapsed { get; }

        void Invoke(Action action);

        TReturn Invoke<TReturn>(Func<TReturn> func);
    }
}