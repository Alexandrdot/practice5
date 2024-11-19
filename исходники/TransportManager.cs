using System;
using System.Collections.Generic;
using Practice5MauiApp;

public class TransportManager
{
    private string firm;
    private string model;
    private int price;

    public TransportManager(string _firm = "NO_FIRM", string _model = "NO_Model", int _price = 0) //конструктор
    {
        Firm = _firm;
        Model = _model;
        Price = _price;
    }

    public string Firm
    {
        get { return firm; } // получить значение
        set //ввести/изменить значение
        {
            if (value.Length < 35 && value.Length > 0) firm = value;
            else firm = "NO_FIRM";
        }
    }
    public string Model
    {
        get { return model; } // получить значение
        set //ввести/изменить значение
        {
            if (value.Length < 35 && value.Length > 0) model = value;
            else model = "NO_Model";
        }
    }
    public int Price
    {
        get { return price; } // получить значение
        set //ввести/изменить значение
        {
            if (value < 99999999999 && value >= 0) price = value;
            else price = 0;
        }
    }

    
}

