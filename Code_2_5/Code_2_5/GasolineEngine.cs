using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_2_5
{
    public class GasolineEngine : Car
    {
        public bool Carburettor { get; set; }

        public GasolineEngine(string brand, string model, int year, int fuelConsumption, int price, bool carburettor) : base(brand, model, year, fuelConsumption, price)
        {
            Carburettor = carburettor;
        }

        public override string ToString()
        {
            return $"{base.ToString()},  наявність карбюратора: {Carburettor} l";
        }
    }
}
