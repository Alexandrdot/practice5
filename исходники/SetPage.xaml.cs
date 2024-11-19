namespace Practice5MauiApp;

public partial class SetPage : ContentPage
{

    private TransportManager selectedTransport = null;
    public SetPage()
	{
		InitializeComponent();
		selectedTransport = SetTransportPage.InfoSetObject(); //что изменяем
        BindingContext = selectedTransport;
        newtorque.IsVisible = BindingContext is Car;
        newtimeworking.IsVisible = BindingContext is EScooter;
    }

    async void SaveChanges(object sender, EventArgs e)
    {
        await DisplayAlert("Сохранение", "Сохранено.", "OK");
        selectedTransport = null;
        await Navigation.PopToRootAsync();
    }
        
}

