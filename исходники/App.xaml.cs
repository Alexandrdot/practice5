namespace Practice5MauiApp;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
        MainPage = new NavigationPage(new MainPage());
	}
}

