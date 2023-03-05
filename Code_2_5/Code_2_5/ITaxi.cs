using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_2_5
{
    public interface ITaxi
    {
        Car[] GetCarsByFuelConsumptionRange(int min, int max);
    }
}
