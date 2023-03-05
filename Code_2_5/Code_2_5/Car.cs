using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_2_5
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int FuelConsumption { get; set; }
        public int Price { get; set; }

        public GasolineEngine gasolineEngine { get; set; }

        public DieselEngine dieselEngine { get; set; }

        public Car(string brand, string model, int year, int fuelConsumption, int price)
        {
            Brand = brand;
            Model = model;
            Year = year;
            FuelConsumption = fuelConsumption;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Brand} {Model} ({Year}) - {FuelConsumption} l/100km, {Price} $";
        }
    }
}
