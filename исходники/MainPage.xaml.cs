using System.Collections.Generic;

namespace Practice5MauiApp;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
        

	}

    static List<TransportManager> transports = new List<TransportManager>(); //список обьектов

    async void ClickedOpenCarPage(object sender, EventArgs e) //создаем страницу с авто
	{
		await Navigation.PushAsync(new CarPage());
	}

    async void ClickedOpenEScooterPage(object sender, EventArgs e) //создаем страницу с самокатом
    {
        await Navigation.PushAsync(new EScooterPage());
    }

    async void ClickedOpenTransportmanagerPage(object sender, EventArgs e) //создаем страницу с т/с
    {
        await Navigation.PushAsync(new TransportManagerPage());
    }

    async void ClickedOpenPrintInfoPage(object sender, EventArgs e) //создаем страницу для вывода списка
    {
        await Navigation.PushAsync(new PrintInfoPage());
    }

    async void ClickedOpenDeletePage(object sender, EventArgs e) //создаем страницу для 
    {
        await Navigation.PushAsync(new DeletePage());
    }

    async void ClickedOpenSetTransportPage(object sender, EventArgs e) //создаем страницу для 
    {
        await Navigation.PushAsync(new SetTransportPage());
    }
    //добавление обьектов в список

    public static void AddCar(Car car)
	{
        transports.Add(car);
	}

    public static void AddEScooter(EScooter scooter)
    {
        transports.Add(scooter);
    }

    public static void AddTransport(TransportManager transport)
    {
        transports.Add(transport);
    }


    public static List<TransportManager> InfoTransports() //для получение списка из страницы с выводом
    {
        return transports;
    }

    public static void DeleteTransport(TransportManager transport)
    {
        transports.Remove(transport);
    }



}


