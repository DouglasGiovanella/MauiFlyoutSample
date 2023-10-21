using System.Reflection;

namespace FlyoutTest;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		MainPage = new NavigationPage(new MainPage());
	}
}

