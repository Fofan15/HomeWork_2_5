namespace Code_2_5
{
    public class TaxiPark : ITaxi
    {
        private Car[] cars;

        private int count;

        public TaxiPark(int size)
        {
            cars = new Car[size];
            count = size;
        }

        public void AddCar(Car car)
        {
            for (int i = 0; i < cars.Length; i++)
            {
                if (cars[i] == null)
                {
                    cars[i] = car;
                    break;
                }
            }
        }

        public Car[] GetCars()
        {
            Car[] result = new Car[count];
            Array.Copy(cars, result, count);
            return result;
        }

        public void AllCars() 
        {
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine($"{cars[i].Brand} {cars[i].Model}  {cars[i].Year} - {cars[i].FuelConsumption} л, {cars[i].Price} $");
            }
        }

        public decimal GetTotalCost()
        {
            decimal totalCost = 0;
            foreach (Car car in cars)
            {
                if (car != null)
                {
                    totalCost += car.Price;
                }
            }
            return totalCost;
        }

        public void SortByFuelConsumption()
        {
            foreach (Car car in cars)
            {
                int n = cars.Length;
                for (int i = 1; i < n; ++i)
                {
                    Car key = cars[i];
                    int j = i - 1;

                    while (j >= 0 && cars[j].FuelConsumption > key.FuelConsumption)
                    {
                        cars[j + 1] = cars[j];
                        j = j - 1;
                    }
                    cars[j + 1] = key;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Відсортовані машини за витратою палива: ");
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine($"{cars[i].Brand} {cars[i].Model} - {cars[i].FuelConsumption} л");
            }
        }

        public Car[] GetCarsByFuelConsumptionRange(int min, int max)
        {
            Car[] result = new Car[cars.Length];
            int index = 0;

            foreach (Car car in cars)
            {
                if (car != null && car.FuelConsumption >= min && car.FuelConsumption <= max)
                {
                    result[index] = car;
                    index++;
                }
            }

            Array.Resize(ref result, index);
            return result;
        }
    }
}

