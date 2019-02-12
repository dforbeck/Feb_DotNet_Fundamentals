using System;
using System.Collections.Generic;

namespace Challenge_Tues_2
{
    internal class CarRepository
    {
        List<Car> _carList;

        internal List<Car> GetCarList()
        {
            _carList = new List<Car>();
            return _carList;
        }

        internal void AddCarToList(Car car)
        {
            _carList.Add(car);
        }

        internal bool GetBooleanFromString(string boolResponse)
        {
            if (boolResponse.Contains("y"))
                return true;
            else
                return false;
        }
    }
}