// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using Code_2_5;

Car car1 = new Car("Toyota", "Camry", 2010, 8, 10000)
{
    gasolineEngine = new GasolineEngine("Toyota", "Camry", 2010, 8, 10000, true)
};

Car car2 = new Car("Mazda", "6", 2015, 7, 15000)
{
    dieselEngine = new DieselEngine("Mazda", "6", 2015, 7, 15000, true)
};

Car car3 = new Car("Honda", "Accord", 2012, 9, 12000)
{
    gasolineEngine = new GasolineEngine("Honda", "Accord", 2012, 9, 12000, false)
};

Car car4 = new Car("Hyundai", "Sonata", 2018, 6, 20000)
{
    dieselEngine = new DieselEngine("Hyundai", "Sonata", 2018, 6, 20000, false)
};

TaxiPark taxipark = new TaxiPark(4);

taxipark.AddCar(car1);
taxipark.AddCar(car2);
taxipark.AddCar(car3);
taxipark.AddCar(car4);

Console.WriteLine("Всі машини в таксопарку:");
taxipark.AllCars();

Console.WriteLine();
Console.WriteLine($"Вартість автопарку: {taxipark.GetTotalCost()} $");

taxipark.SortByFuelConsumption();

Console.WriteLine();
Console.WriteLine("Знайдена машина в діапазоні витрати палива: 7 - 8");
Car[] carsInRange = taxipark.GetCarsByFuelConsumptionRange(7, 8);

foreach (Car car in carsInRange)
{
    Console.WriteLine(car.ToString());
}

Console.WriteLine("Знаходження машини в діапазоні витрати палива: 8 - 9");
Car carToFind = taxipark.FindCarByFuelConsumption(8, 9);

if (carToFind != null)
{
    Console.WriteLine();
    Console.WriteLine($"Знайдена машина: {carToFind.Model}");
}
else
{
    Console.WriteLine();
    Console.WriteLine("Машини не знайдено");
}
