using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInventory
{
    internal class Car
    {
        public string year, make, color, mileage;

        public Car(string _year, string _make, string _color, string _mileage)
        {
            year = _year;
            make = _make;
            color = _color;
            mileage = _mileage;
        }
    }
}
