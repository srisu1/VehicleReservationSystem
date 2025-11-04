using System;

namespace Vehicle_Reservation_System.Models;

public class Truck:Vehicle
{
    public double loadCapacity { get; set; }
    public bool hasRefrigeration { get; set; }

    public Truck(string RegistrationNumber, string Model, string Manufacturer, double Price, 
        double LoadCapacity) : base( RegistrationNumber, Model, Manufacturer, Price)
    {
        loadCapacity = LoadCapacity;
        hasRefrigeration = true;
    }
    
    public override string GetVehicleType()
    {
        return "Truck";
    }
}