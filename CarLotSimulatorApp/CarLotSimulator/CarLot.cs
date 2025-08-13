using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    public class CarLot
    {
        public List<Car> ParkingLot = new List<Car>();

        // Static field to track total cars
        public static int numberOfCars = 0;

        public void CheckCars()
        {
            foreach (var vehicleCar in ParkingLot)
            {
                Console.WriteLine($"{vehicleCar.Year} {vehicleCar.Make} {vehicleCar.Model}");
            }
        }
    }
}