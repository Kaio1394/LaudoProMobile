using System.Windows.Input;

namespace LaudoProApp.Components;

public partial class CustomButton : ContentView
{
    public CustomButton()
    {
        InitializeComponent();

        #region BtnAction
        var tapGesture = new TapGestureRecognizer();
        tapGesture.Tapped += (s, e) =>
        {
            Command?.Execute(null);
        };
        buttonFrame.GestureRecognizers.Add(tapGesture);
        #endregion

    }

    #region Text Property Button
    public static readonly BindableProperty TextProperty =
       BindableProperty.Create(nameof(Text), typeof(string), typeof(CustomButton), string.Empty);

    public string Text
    {
        get => (string)GetValue(TextProperty);
        set => SetValue(TextProperty, value);
    }
    #endregion

    #region Command Property Button
    public static readonly BindableProperty CommandProperty =
    BindableProperty.Create(nameof(Command), typeof(ICommand), typeof(CustomButton));

    public ICommand Command
    {
        get => (ICommand)GetValue(CommandProperty);
        set => SetValue(CommandProperty, value);
    }
    #endregion
}