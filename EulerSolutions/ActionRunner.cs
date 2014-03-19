using System;

namespace EulerSolutions
{
    public class ActionRunner:IActionRunner
    {
        public void Invoke(Action action)
        {
            Invoke<object>(() =>
            {
                action.Invoke();
                return null;
            });
        }

        public TReturn Invoke<TReturn>(Func<TReturn> func)
        {
            return func.Invoke();
        }
    }
}
