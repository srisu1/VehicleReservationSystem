using System;
using System.Collections.Generic;

using Vehicle_Reservation_System.Models;
using Vehicle_Reservation_System.Services.Interfaces;

namespace Vehicle_Reservation_System.Services;

public class VehicleService: IVehicleService

{
   private List<Vehicle> vehicles = new List<Vehicle>();

   public void AddVehicle(Vehicle vehicle)
   {
      vehicles.Add(vehicle);
   }

   public Vehicle GetVehicleByRegistrationNumber(string RegistrationNumber)
   {
      foreach (Vehicle vehicle in vehicles)
      {
         if (vehicle.registrationNumber == RegistrationNumber)
         {
            return vehicle;
         }
      }
      return null;
   }

   public List<Vehicle> GetAvailableVehicles()
   {
      List<Vehicle> availableVehicles = new List<Vehicle>();
      
      foreach (Vehicle vehicle in vehicles)
      {
         if (vehicle.isAvailable == true)
         {
            
            availableVehicles.Add(vehicle);
           
         }
      }
      return availableVehicles;
   }

   public void ShowAllVehicles()
   {
      string status;
      
      foreach (Vehicle vehicle in vehicles)
      {
         if (vehicle.isAvailable == true)
         {
            status = "Available";
         }
         else
         {
            status = "Unavailable";
         }
         Console.WriteLine($"{vehicle.registrationNumber}| {vehicle.GetVehicleType()}| {status}");
      }
      
      
   }
   
}

