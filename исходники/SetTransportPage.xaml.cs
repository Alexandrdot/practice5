namespace Practice5MauiApp;

public partial class SetTransportPage : ContentPage
{
    private static TransportManager selectedTransport = null;

    public SetTransportPage()
	{
        InitializeComponent();
        List<TransportManager> transports = MainPage.InfoTransports();
        listset.ItemsSource = transports;
    }
    private void UserChoiceSet(object sender, EventArgs e)
    {
        if (sender is ListView listView)
        {
            selectedTransport = (TransportManager)listView.SelectedItem;
           
        }

    }
    async void ClickSetObject(object sender, EventArgs e)
    {
        if (selectedTransport != null)
        {
            await Navigation.PushAsync(new SetPage());
            selectedTransport = null;
        }
    }

    public static TransportManager InfoSetObject() //для получения обьекта изменения с новой страницы
    {
        return selectedTransport;

    }

    

}
