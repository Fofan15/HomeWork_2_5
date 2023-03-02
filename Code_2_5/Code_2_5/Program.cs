// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using Code_2_5;

DieselCar dieselcar = new DieselCar("Toyota", "Camry", 2010, 8, 10000, 70);
GasolineCar gasolinecar = new GasolineCar("Mazda", "6", 2015, 7, 15000, 60);
DieselCar dieselcar1 = new DieselCar("Honda", "Accord", 2012, 9, 12000, 80);
GasolineCar gasolinecar1 = new GasolineCar("Hyundai", "Sonata", 2018, 6, 20000, 50);

TaxiPark taxipark = new TaxiPark(4);

taxipark.AddCar(dieselcar);
taxipark.AddCar(gasolinecar);
taxipark.AddCar(dieselcar1);
taxipark.AddCar(gasolinecar1);

Console.WriteLine("Всі машини в таксопарку:");
taxipark.AllCars();

Console.WriteLine();
Console.WriteLine($"Вартість автопарку: {taxipark.GetTotalCost()} $");

taxipark.SortByFuelConsumption();

Console.WriteLine();
Car[] carsInRange = taxipark.GetCarsByFuelConsumptionRange(7, 8);

foreach (Car car in carsInRange)
{
    Console.WriteLine(car.ToString());
}


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
