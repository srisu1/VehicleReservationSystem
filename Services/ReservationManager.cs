using System;
using Vehicle_Reservation_System.Models;
using Vehicle_Reservation_System.Services.Interfaces;
namespace Vehicle_Reservation_System.Services;

public class ReservationManager
{
    private readonly IVehicleService vehicleService;
    private readonly IReservationService reservationService;

    public ReservationManager(IVehicleService VehicleService, IReservationService ReservationService)
    {
        vehicleService = VehicleService;
        reservationService = ReservationService;
    }
    
    public void ReserveVehicle(User user, string registrationNumber, int days)
    {
        Vehicle vehicle = vehicleService.GetVehicleByRegistrationNumber(registrationNumber);

        if (vehicle == null)
        {
            Console.WriteLine("Vehicle not found.");
            return;
        }

        reservationService.MakeReservation(new Reservation(user, vehicle, days));
    }
    
    
    
}