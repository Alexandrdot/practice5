namespace Practice5MauiApp;

public partial class EScooterPage : ContentPage
{
	public EScooterPage()
	{
		InitializeComponent();
	}
    EScooter scooter = new EScooter();
    
    async void ClickSaveEScooter(object sender, EventArgs e)
	{
        int.TryParse(expprice.Text, out int price);
        int.TryParse(exptimeworking.Text, out int timeworking);
        if (string.IsNullOrEmpty(expfirm.Text) == false && string.IsNullOrEmpty(expmodel.Text) == false)
        {
            scooter.Firm = expfirm.Text;
            scooter.Model = expmodel.Text;
            scooter.Price = price;
            scooter.TimeWorking = timeworking;
            MainPage.AddEScooter(scooter); //добавление в список
            await Navigation.PopAsync();
        }
        else
        {
            await DisplayAlert("Ошибка", "Пожалуйста, заполните поля: марка, модель", "OK");
        }
        

        
    }
}
