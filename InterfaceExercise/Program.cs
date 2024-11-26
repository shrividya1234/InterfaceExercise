using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces
          
        var carOne = new Car();
        carOne.Color = "Red";
        carOne.IsHybrid = true;
        carOne.IsAutodrive = true;
        carOne.Headquaters = "NewYork";
        carOne.Logo = "Lion";
        carOne.Trunk = true;
        carOne.TrunkSpace = 4;
        carOne.NumberOfWheels = 4;
        
        var trunkOne = new Trunk();
        trunkOne.Color = "Blue";
        trunkOne.IsHybrid = true;
        trunkOne.IsAutodrive = true;
        trunkOne.Headquaters = "China";
        trunkOne.Logo = "Car Logo";
        trunkOne.TrunkBedSpace = 10;
        trunkOne.NumberOfWheels = 4;
        
        var SUVOne = new SUV();
        SUVOne.Color = "grey";
        SUVOne.IsHybrid = true;
        SUVOne.IsAutodrive = true;
        SUVOne.Headquaters = "Japan";
        SUVOne.Logo = "SUV Logo";
        SUVOne.Row = 3;
        SUVOne.CargoSpace = 8;
        SUVOne.NumberOfWheels = 4;
        
        var ParkingLot = new List<IVehicle>(){carOne,trunkOne,SUVOne};
        foreach (var ride in ParkingLot)
        {
            Console.WriteLine($"Color of the car : {ride.Color} \n  Is that hybrid : {ride.IsHybrid} \n Is it autodrive : {ride.IsAutodrive} \n  " +
                              $"Number of Wheels :{ride.NumberOfWheels} \n ");
        }
     
     
        }
    }
}
