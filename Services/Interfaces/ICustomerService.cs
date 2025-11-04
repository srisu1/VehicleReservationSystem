using System.Collections.Generic;
using Vehicle_Reservation_System.Models;

namespace Vehicle_Reservation_System.Services.Interfaces;

public interface ICustomerService
{
    void AddCustomer(User user);
}