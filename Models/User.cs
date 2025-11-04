using System;


namespace Vehicle_Reservation_System.Models;

public class User
{
    public string name { get; set; }
    public string email { get; set; }
    public string phoneNumber { get; set; }

    public User(string Name, string Email, string PhoneNumber)
    {
        name = Name;
        email = Email;
        phoneNumber = PhoneNumber;
    }

    public override string ToString()
    {
        return $"{name} | {email} |{phoneNumber}";
    }
}