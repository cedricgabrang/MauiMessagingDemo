using CommunityToolkit.Mvvm.Messaging;
using MauiMessagingDemo.ViewModels;
using MauiMessagingDemo.Messages;

namespace MauiMessagingDemo;

public partial class MainPage : ContentPage
{
	public MainPage(MainPageViewModel viewModel)
	{
		InitializeComponent();

		BindingContext = viewModel;
	}

    private void OnSendMessageClicked(object sender, EventArgs e)
	{
		WeakReferenceMessenger.Default.Send(new MyMessage("Hello World!"));
	}
}

