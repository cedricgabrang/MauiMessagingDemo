using CommunityToolkit.Mvvm.Messaging.Messages;

namespace MauiMessagingDemo.Messages
{
    public class MyMessage : ValueChangedMessage<string>
    {
        public MyMessage(string value) : base(value)
        {
        }
    }
}
