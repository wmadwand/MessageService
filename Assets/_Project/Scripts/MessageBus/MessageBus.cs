using Bluehorse.Core.Helper;

namespace Bluehorse.Game.Messages
{
    public sealed class MessageBus
	{
        public static readonly Message<string, float, object> SampleMessage01 = new Message<string, float, object>();
        public static readonly Message<string, float, object> SampleMessage02 = new Message<string, float, object>();
        public static readonly Message<string, float, object> SampleMessage03 = new Message<string, float, object>();
    }	

	public class MessageArgs
	{
		public static readonly MessageArgs None = new MessageArgs();

		public override string ToString()
		{
			return "()";
		}
	}
}