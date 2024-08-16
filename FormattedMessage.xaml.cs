using MauiTest.Extensions;
using MauiTest.Models;

namespace MauiTest;

public partial class FormattedMessage : ContentView
{
	public IList<FormattedText>? FormattedText { get; set; }

	public static readonly BindableProperty MessageProperty = BindableProperty.Create(nameof(Message), typeof(IList<FormattedText>), typeof(FormattedMessage), null);

	public string Message
	{
		get => (string)GetValue(MessageProperty);
		set
		{
			SetValue(MessageProperty, value);
            FormattedText = value.GetFormattedMessage();
			OnPropertyChanged(nameof(FormattedText));
        }
	}

	public FormattedMessage()
	{
		InitializeComponent();
		BindingContext = this;
	}
}