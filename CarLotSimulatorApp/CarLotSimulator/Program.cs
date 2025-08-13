using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var carLotOne = new CarLot();

            var carOne = new Car();
            carOne.Make = "Chrysler";
            carOne.Model = "ThunderBolt Roadster";
            carOne.Year = 1941;
            carOne.IsDriveable = true;
            carOne.MakeEngineNoise("Vroom");
            carOne.MakeHonkNoise("Honk");

            carLotOne.ParkingLot.Add(carOne);

            var carTwo = new Car()
            {
                Make = "Mercury",
                Model = "Club Coupe",
                Year = 1940,
                IsDriveable = false
            };
            carTwo.MakeEngineNoise("Roar");
            carTwo.MakeHonkNoise("Beep");

            carLotOne.ParkingLot.Add(carTwo);

            var carThree = new Car("Studebaker", "Champion", 1948, true);
            carThree.MakeEngineNoise("Vroom vroooom!");
            carThree.MakeHonkNoise("BEEP BEEEP BEEEEEP!");

            carLotOne.ParkingLot.Add(carThree);

            Console.WriteLine("\nCars currently in the lot:");
            carLotOne.CheckCars();

            Console.WriteLine($"\nFinal number of cars in the lot: {CarLot.numberOfCars}");
        }
    }
}
