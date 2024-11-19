namespace Practice5MauiApp;

public partial class TransportManagerPage : ContentPage
{
	public TransportManagerPage()
	{
		InitializeComponent();
	}
    TransportManager transport = new TransportManager();

    async void ClickSaveTransport(object sender, EventArgs e)
    {
        int.TryParse(expprice.Text, out int price);

        transport.Firm = string.IsNullOrEmpty(expfirm.Text) ? transport.Firm : expfirm.Text;
        transport.Model = string.IsNullOrEmpty(expmodel.Text) ? transport.Firm : expfirm.Text;
        transport.Price = price;
        
        if (string.IsNullOrEmpty(expfirm.Text) == false && string.IsNullOrEmpty(expmodel.Text) == false)
        {
            transport.Firm = expfirm.Text;
            transport.Model = expmodel.Text;
            transport.Price = price;
            MainPage.AddTransport(transport); //добавление в список
            await Navigation.PopAsync();
        }
        else
        {
            await DisplayAlert("Ошибка", "Пожалуйста, заполните поля: марка, модель", "OK");
        }
        
    }
}
