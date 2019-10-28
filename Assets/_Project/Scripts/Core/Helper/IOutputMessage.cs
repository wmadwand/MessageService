namespace Bluehorse.Core.Helper
{
    public interface IOutputMessage
    {
        void Send();
    }

    public interface IOutputMessage<T>
    {
        void Send(T arg);
    }

    public interface IOutputMessage<T1, T2>
    {
        void Send(T1 arg1, T2 arg2);
    }

    public interface IOutputMessage<T1, T2, T3>
    {
        void Send(T1 arg1, T2 arg2, T3 arg3);
    }

    public interface IOutputMessage<T1, T2, T3, T4>
    {
        void Send(T1 arg1, T2 arg2, T3 arg3, T4 arg4);
    }
}