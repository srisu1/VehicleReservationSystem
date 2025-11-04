using System;

namespace Vehicle_Reservation_System.Models;

public class Car: Vehicle
{
    public int numberOfDoors { get; set; }
    public string brand { get; set; }
    public string fuelType { get; set; }

    public Car(string RegistrationNumber, string Model, string Manufacturer, double Price,
        int NumberOfDoors, string Brand, string FuelType) : base(RegistrationNumber, Model, Manufacturer, Price)
    {
        numberOfDoors = NumberOfDoors;
        brand = Brand;
        fuelType = FuelType;
    }

    public override string GetVehicleType()
    {
        return "Car";
    }
}