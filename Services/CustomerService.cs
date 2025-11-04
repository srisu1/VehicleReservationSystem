using System;
using System.Collections.Generic;
using Vehicle_Reservation_System.Models;
using Vehicle_Reservation_System.Services.Interfaces;

namespace Vehicle_Reservation_System.Services;

public class CustomerService: ICustomerService
{
    private List<User> customers = new List<User>();
    public void AddCustomer(User user)
    {
        customers.Add(user);
        Console.WriteLine("Customer Added");
    }
}