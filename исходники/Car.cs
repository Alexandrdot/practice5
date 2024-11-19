using System;
using System.Collections.Generic;
using System.ComponentModel;

public class Car : TransportManager //наследуем базовый класс
{

    private int torque; //крутящий момент

    public Car(string _firm = "NO_FIRM", string _model = "NO_Model", int _price = 0, int _torque = 0) : base(_firm, _model, _price) //конструктор
    {
        Torque = _torque;
    }
  

    public int Torque
    {
        get { return torque; } // получить значение
        set //ввести/изменить значение
        {
            if (value < 2000 && value >= 0) torque = value;
            else torque = 0;
        }
    }
    

}
