using System;

namespace EulerSolutions
{
    public interface IActionRunner
    {
        void Invoke(Action action);

        TReturn Invoke<TReturn>(Func<TReturn> func);
    }
}