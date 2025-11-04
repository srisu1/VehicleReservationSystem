using System;


namespace Vehicle_Reservation_System.Models;

public abstract class Vehicle
{
    public string registrationNumber {get; set;}
    public string model { get; set; }
    public string manufacturer { get; set; }
    public double price { get; set; }
    public bool isAvailable { get; set; }

    public Vehicle(string RegistrationNumber, string Model, string Manufacturer, double Price)
    {
        registrationNumber = RegistrationNumber;
        model= Model;
        manufacturer = Manufacturer;
        price = Price;
        isAvailable = true;
    }

    public abstract string GetVehicleType();

    public double CalculateRentalCosts(int days)
    {
        return price*days;
    }



}