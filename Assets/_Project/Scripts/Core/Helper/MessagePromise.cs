namespace Bluehorse.Core.Helper
{
    public interface IMessagePromise
    {
        bool IsReceived { get; }
    }

    public sealed class MessagePromise : IMessagePromise
    {
        public bool IsReceived { get; private set; }

        private IInputMessage _message;

        public MessagePromise(IInputMessage message)
        {
            _message = message;
            _message.Receive += OnReceive;
        }

        public void Reset()
        {
            IsReceived = false;
        }

        private void OnReceive()
        {
            IsReceived = true;
            _message.Receive -= OnReceive;
        }
    }

    public sealed class MessagePromise<T> : IMessagePromise
    {
        public bool IsReceived { get; private set; }

        public T Result { get; private set; }

        private IInputMessage<T> _message;

        public MessagePromise(IInputMessage<T> message)
        {
            _message = message;
            _message.Receive += OnReceive;
        }

        public void Reset()
        {
            IsReceived = false;
        }

        private void OnReceive(T result)
        {
            IsReceived = true;
            Result = result;
            _message.Receive -= OnReceive;
        }
    }

    public static class MessagePromiseExtensions
    {
        public static MessagePromise GetPromise(this IInputMessage inputMessage)
        {
            return new MessagePromise(inputMessage);
        }

        public static MessagePromise<T> GetPromise<T>(this IInputMessage<T> inputMessage)
        {
            return new MessagePromise<T>(inputMessage);
        }
    }
}
