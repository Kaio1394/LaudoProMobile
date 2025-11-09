using LaudoProApp.ViewModels;

namespace LaudoProApp.Views;

public partial class RegisterPage : ContentPage
{
	public RegisterPage(RegisterViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
    }
}