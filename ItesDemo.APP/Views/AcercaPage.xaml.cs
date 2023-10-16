using System.Windows.Input;

namespace ItesDemo.APP.Views;

public partial class AcercaPage : ContentPage
{
	public AcercaPage()
	{
		InitializeComponent();
    }

    async void OnButtonClicked(object sender, EventArgs args)
    {
        await Launcher.OpenAsync("https://github.com/LittleCat27/ItesDemo.APP");
    }
}