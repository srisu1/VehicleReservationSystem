using System.Collections.Generic;
using Vehicle_Reservation_System.Models;
namespace Vehicle_Reservation_System.Services.Interfaces;

public interface IVehicleService
{
    void AddVehicle(Vehicle vehicle);
    Vehicle GetVehicleByRegistrationNumber(string RegistrationNumber);
    List<Vehicle> GetAvailableVehicles();
    void ShowAllVehicles();


}