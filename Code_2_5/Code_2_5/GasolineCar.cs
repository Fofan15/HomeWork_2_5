using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_2_5
{
    public class GasolineCar : Car
    {
        public int TankVolume { get; set; }

        public GasolineCar(string brand, string model, int year, int fuelConsumption, int price, int tankVolume)
            : base(brand, model, year, fuelConsumption, price)
        {
            TankVolume = tankVolume;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, oб'єм резервуара: {TankVolume} l";
        }
    }
}
