using LaudoProApp.ViewModels;

namespace LaudoProApp.Views;

public partial class RegisterPage : ContentPage
{
	public RegisterPage()
	{
		InitializeComponent();
		BindingContext = new RegisterViewModel();
    }
}