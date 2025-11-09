using LaudoProApp.ViewModels;

namespace LaudoProApp.Views;

public partial class ForgotPasswordPage : ContentPage
{
	public ForgotPasswordPage(ForgotPasswordViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
    }
}