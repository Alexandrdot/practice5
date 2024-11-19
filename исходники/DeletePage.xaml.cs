using Microsoft.Maui.Controls;

namespace Practice5MauiApp;

public partial class DeletePage : ContentPage
{
    private TransportManager selectedTransport;

    public DeletePage()
    {
        InitializeComponent();
        List<TransportManager> transports = MainPage.InfoTransports();
        list.ItemsSource = transports;
    }
        


    private void UserChoice(object sender, EventArgs e)
	{
        if (sender is ListView listView)
        {
            selectedTransport = (TransportManager)listView.SelectedItem;
        }
        //на что кликнули
    }
	async void ClickDeleteObject(object sender, EventArgs e)
	{
        //если кликнули удалить
        if (selectedTransport != null)
        {
            MainPage.DeleteTransport(selectedTransport);
            list.ItemsSource = MainPage.InfoTransports();
            await DisplayAlert("Удаление", "Объект удалён.", "OK");
            selectedTransport = null;
            await Navigation.PopAsync();
        }
    }
}
