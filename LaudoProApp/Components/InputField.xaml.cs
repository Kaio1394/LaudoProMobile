namespace LaudoProApp.Components;

public partial class InputField : ContentView
{
	public InputField()
	{
		InitializeComponent();
	}

	public static readonly BindableProperty PlaceholderProperty =
	   BindableProperty.Create(nameof(Placeholder), typeof(string), typeof(InputField), string.Empty);

	public string Placeholder 
	{
		get => (string)GetValue(PlaceholderProperty);
		set => SetValue(PlaceholderProperty, value);
    }
}