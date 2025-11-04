using System;
namespace Vehicle_Reservation_System.Models;

public class Scooter: Vehicle
{
    public bool isElectric { get; set; }
    public int batteryCapacity { get; set; }
    
    public Scooter(string RegistrationNumber, string Model, string Manufacturer, double Price, bool IsElectric, int BatteryCapacity): base (
        RegistrationNumber, Model, Manufacturer, Price )
    {
        isElectric=IsElectric;
        batteryCapacity=BatteryCapacity;
    }


    public override string GetVehicleType()
    {
        return "Scooter";
    }
}