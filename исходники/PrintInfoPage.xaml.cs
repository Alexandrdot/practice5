namespace Practice5MauiApp;

public partial class PrintInfoPage : ContentPage
{
    public PrintInfoPage()
	{
		InitializeComponent();
		List<TransportManager> transports = MainPage.InfoTransports();
        collectionView.ItemsSource = transports;
    }
}
