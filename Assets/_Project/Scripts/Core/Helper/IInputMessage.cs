using System;

namespace Bluehorse.Core.Helper
{
    public interface IInputMessage
    {
        event Action Receive;
    }

    public interface IInputMessage<T>
    {
        event Action<T> Receive;
    }

    public interface IInputMessage<T1, T2>
    {
        event Action<T1, T2> Receive;
    }

    public interface IInputMessage<T1, T2, T3>
    {
        event Action<T1, T2, T3> Receive;
    }

    public interface IInputMessage<T1, T2, T3, T4>
    {
        event Action<T1, T2, T3, T4> Receive;
    }
}