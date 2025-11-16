using LaudoProApp.ViewModels;

namespace LaudoProApp.Views;

public partial class ForgotPasswordPage : ContentPage
{
	public ForgotPasswordPage()
	{
		InitializeComponent();
		BindingContext = new ForgotPasswordViewModel();
    }
}