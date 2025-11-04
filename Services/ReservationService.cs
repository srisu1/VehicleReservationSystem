using System;
using System.Collections.Generic;
using Vehicle_Reservation_System.Models;
using Vehicle_Reservation_System.Services.Interfaces;

namespace Vehicle_Reservation_System.Services;

public class ReservationService: IReservationService
{
    private List<Reservation> reservations = new List<Reservation>();
    private IVehicleService vehicleService;
    
    public ReservationService(IVehicleService VehicleService)
    {
        vehicleService = VehicleService;
    }
    
    
    
    public void MakeReservation(Reservation reservation)
    {
        bool tryAgain=true;
        while (tryAgain)
        {
            if (reservation.vehicle.isAvailable)
            {
                reservation.vehicle.isAvailable = false;
                reservations.Add(reservation);
                Console.WriteLine("Reservation is Completed. Thanks.");
                Console.WriteLine(reservation);
                tryAgain = false;
            }

            else
            {
                Console.WriteLine("Sorry the vehicle is unavailable.");
                Console.WriteLine("Would you like to try again with a differen vehicle? (Yes/NO)");

                string answer = Console.ReadLine().ToLower();
                if (answer == "yes")
                {
                    Console.WriteLine("Please enter the registration number of a different vehicle");
                    string newReg=Console.ReadLine();
                    
                    Vehicle newVehicle = vehicleService.GetVehicleByRegistrationNumber(newReg);

                    
                    if (newVehicle != null)
                    {
                        reservation.vehicle = newVehicle;
                    }
                    else
                    {
                        Console.WriteLine("No vehicle found with that registration number.");
                    }
                    
                }

                else
                {
                    Console.WriteLine("Registration cancelled");
                    tryAgain = false;
                }
            }
            
        }
        
        
    }

    public List<Reservation> GetAllReservations()
    {
        return reservations;
    }
}