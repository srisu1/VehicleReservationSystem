# Vehicle Reservation System

A console application built in C# to practise object oriented programming with an abstract base class, concrete subclasses, and composition. Built during my internship at Global Square IT Company as a hands-on OOP exercise.

## Purpose

The system models a small vehicle rental scenario. The point of the project was to give myself a working example of OOP concepts in one place:

- An abstract base class with shared properties and an abstract method
- Several concrete subclasses overriding the abstract method
- A separate class that composes objects of different types
- Polymorphic behaviour at runtime

## Tech stack

- C# 12
- .NET 9
- JetBrains Rider on macOS

## Domain model

```
            ┌──────────────────────┐
            │   Vehicle  {abstract}│
            │ ─ registrationNumber │
            │ ─ model              │
            │ ─ manufacturer       │
            │ ─ price              │
            │ ─ isAvailable        │
            │ + CalculateRentalCosts│
            │ + GetVehicleType {abs}│
            └──────────▲───────────┘
                       │ inherits
       ┌───────────┬───┴───┬───────────┐
       │           │       │           │
     ┌─┴─┐      ┌──┴──┐ ┌──┴──┐   ┌───┴───┐
     │Car│      │Truck│ │Bike │   │Scooter│
     └───┘      └─────┘ └─────┘   └───────┘

User ──┐
       │ composes
       ▼
   Reservation  ──┐
                  │ composes
                  ▼
                Vehicle
```

## Project structure

- `Models/Vehicle.cs`  ·  abstract base class
- `Models/Car.cs`  ·  Car subclass (numberOfDoors, brand, fuelType)
- `Models/Truck.cs`  ·  Truck subclass (loadCapacity, hasRefrigeration)
- `Models/Bike.cs`  ·  Bike subclass (engineCC, mileage)
- `Models/Scooter.cs`  ·  Scooter subclass (isElectric, batteryCapacity)
- `Models/User.cs`  ·  User entity
- `Models/Reservation.cs`  ·  composes User + Vehicle and calculates total cost
- `Services/VehicleService.cs`  ·  manages the vehicle inventory
- `Services/ReservationManager.cs`  ·  creates and tracks reservations
- `Services/Interfaces/`  ·  IVehicleService, IReservationService, ICustomerService
- `Program.cs`  ·  console entry point

## How to run

```bash
git clone https://github.com/srisu1/VehicleReservationSystem.git
cd VehicleReservationSystem
dotnet run
```

## Features

- Browse the vehicle inventory grouped by type
- Make a reservation by selecting a vehicle and entering rental days
- Automatic rental cost calculation via `Vehicle.CalculateRentalCosts(days)`
- Mark vehicles available or unavailable

## What I learnt

- Designing class hierarchies with an abstract base and concrete subclasses
- When inheritance fits and when composition is the better choice
- Method overriding (`override` keyword in C#)
- The use of `abstract` versus `virtual` methods
- Building behaviour through polymorphism (calling `GetVehicleType()` on any `Vehicle`)
- Separating interfaces from implementations for testability

## Next steps

- Persist vehicles and reservations to a database
- Wrap the logic in a Web API
- Add unit tests for the rental cost calculations and availability transitions

## Author

Srisu Karki  ·  Backend Intern, Global Square IT Company  ·  November 2025
