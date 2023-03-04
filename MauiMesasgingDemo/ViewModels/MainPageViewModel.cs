using CommunityToolkit.Mvvm.Messaging;
using MauiMessagingDemo.Messages;

namespace MauiMessagingDemo.ViewModels
{
    public class MainPageViewModel
    {
        public MainPageViewModel()
        {
            WeakReferenceMessenger.Default.Register<MyMessage>(this, (r, m) =>
            {
                OnMessageReceived(m.Value);
            });
        }

        private static void OnMessageReceived(string message)
        {
            Shell.Current.DisplayAlert("Message received", message, "OK");
        }
    }
}
