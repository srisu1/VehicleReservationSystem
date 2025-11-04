using System;
namespace Vehicle_Reservation_System.Models;

public class Bike : Vehicle
{
    public int engineCC { get; set; }
    public double mileage { get; set; }

    public Bike(string ResgistrationNumber, string Model, string Manufacturer, double Price, int EngineCC,
        double Mileage) : base(ResgistrationNumber, Model, Manufacturer, Price)
    {
        engineCC = EngineCC;
        mileage = Mileage;
    }

    public override string GetVehicleType()
    {
        return "Bike";
    }
}