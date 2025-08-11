using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class CarLot
    {
        public CarLot() { }
        public List<Car> ParkingLot = new List<Car>();

        public void CheckCars()
        {
            foreach (var vehicleCar in ParkingLot)
            {
                Console.WriteLine($"{vehicleCar.Make} {vehicleCar.Model} {vehicleCar.Year}"

              );

            }

        }

        public static int NumberOfCars=0;

    }
}
