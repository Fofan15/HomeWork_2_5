using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_2_5
{
    public class DieselEngine : Car
    {
        public bool Turbocharged { get; set; }

        public DieselEngine(string brand, string model, int year, int fuelConsumption, int price, bool turbocharged) : base(brand, model, year, fuelConsumption, price)
        {
            Turbocharged = turbocharged;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, наявність турбонадува: {Turbocharged} l";
        }
    }
}
