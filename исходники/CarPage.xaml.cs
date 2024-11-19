namespace Practice5MauiApp;

public partial class CarPage : ContentPage
{

	public CarPage()
	{
		InitializeComponent();
	}
    Car car = new Car();

    //сохраняем в список, если все хорошо
    async void ClickSaveCar(object sender, EventArgs e)
	{
        int.TryParse(expprice.Text, out int price);
        int.TryParse(exptorque.Text, out int torque);
        if (string.IsNullOrEmpty(expfirm.Text) == false && string.IsNullOrEmpty(expmodel.Text) == false)
        {
            car.Firm = expfirm.Text;
            car.Model = expmodel.Text;
            car.Price = price;
            car.Torque = torque;
            MainPage.AddCar(car); //добавление в список
            await Navigation.PopAsync();
        }
        else
        {
            await DisplayAlert("Ошибка", "Пожалуйста, заполните поля: марка, модель", "OK");
        }

        
    }
}