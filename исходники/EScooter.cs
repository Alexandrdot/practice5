using System;
using System.Collections.Generic;

public class EScooter : TransportManager
{
    private int timeWorking; //время работы

    public EScooter(string _firm = "NO_FIRM", string _model = "NO_Model", int _price = 0, int _timeWorking = 0) : base(_firm, _model, _price) //конструктор
    {
        TimeWorking = _timeWorking;
    }

    public int TimeWorking
    {
        get { return timeWorking; } // получить значение
        set //ввести/изменить значение
        {
            if (value > 0 && value < 1500) timeWorking = value;
            else timeWorking = 0;
        }
    }  
}
