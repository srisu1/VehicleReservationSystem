using System;
namespace Vehicle_Reservation_System.Models;

public class Reservation
{
    public User user { get; set; }
    public Vehicle vehicle { get; set; }
    public int numOfDays { get; set; }
    public double totalCost { get; set; }

    public Reservation(User UserName, Vehicle VehicleName, int NumOfDays)
    {
        user = UserName;
        vehicle = VehicleName;
        numOfDays= NumOfDays;
        totalCost = vehicle.CalculateRentalCosts(numOfDays);
        
    }

    public override string ToString()
    {
        return $"{user}| {vehicle}| {numOfDays}| {totalCost}";
    }
}