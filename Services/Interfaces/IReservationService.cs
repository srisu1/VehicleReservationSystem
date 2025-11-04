using System.Collections.Generic;
using Vehicle_Reservation_System.Models;

namespace Vehicle_Reservation_System.Services.Interfaces;

public interface IReservationService
{
    void MakeReservation(Reservation reservation);
    List<Reservation> GetAllReservations();
}