using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_2_5
{
    public static class TaxiParkExtensions
    {
        public static Car FindCarByFuelConsumption(this TaxiPark taxiPark, double minFuelConsumption, double maxFuelConsumption)
        {
            foreach (var car in taxiPark.GetCars())
            {
                if (car.FuelConsumption >= minFuelConsumption && car.FuelConsumption <= maxFuelConsumption)
                {
                    return car;
                }
            }
            return null;
        }
    }
}
