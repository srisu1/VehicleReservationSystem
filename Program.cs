using System;
using Vehicle_Reservation_System.Models;
using Vehicle_Reservation_System.Services;

namespace Vehicle_Reservation_System;

class Program
    {
        static void Main(string[] args)
        {
          
            VehicleService vehicleService = new VehicleService();
            ReservationService reservationService = new ReservationService(vehicleService);
            CustomerService customerService = new CustomerService();
            ReservationManager reservationManager = new ReservationManager(vehicleService, reservationService);

          
            vehicleService.AddVehicle(new Car("BA001", "Civic", "Honda", 1000, 4, "Honda", "Petrol"));
            vehicleService.AddVehicle(new Car("BA002", "Corolla", "Toyota", 900, 4, "Toyota", "Diesel"));
            vehicleService.AddVehicle(new Scooter("BA003", "Vespa", "Piaggio", 300, true, 50));
          
           
           
            bool running = true;

            while (running)
            {
                Console.WriteLine("----------Vehicle Reservation System---------");
                Console.WriteLine("1. Show all vehicles");
                Console.WriteLine("2. Make a reservation");
                Console.WriteLine("3. Show all reservations");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.WriteLine("----------All Vehicles-----------");
                        vehicleService.ShowAllVehicles();
                        break;

                    case "2":
                        Console.Write("Enter your name-");
                        string name = Console.ReadLine();

                        Console.Write("Enter your email-");
                        string email = Console.ReadLine();

                        Console.Write("Enter your phone number-");
                        string phone = Console.ReadLine();

                        Console.Write("Enter vehicle registration number-");
                        string reg = Console.ReadLine();

                        Console.Write("Enter number of days- ");
                        int days;
                        while (!int.TryParse(Console.ReadLine(), out days) || days <= 0)
                        {
                            Console.Write("Please enter a valid number of days: ");
                        }

                        User currentUser = new User(name, email, phone);
                        customerService.AddCustomer(currentUser);

                        reservationManager.ReserveVehicle(currentUser, reg, days);
                        break;


                    case "3":
                        Console.WriteLine("--------All Reservations----------");
                        foreach (var r in reservationService.GetAllReservations())
                        {
                            Console.WriteLine(r);
                        }
                        break;

                    case "4":
                        running = false;
                        Console.WriteLine("Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }
            }
        }
}

