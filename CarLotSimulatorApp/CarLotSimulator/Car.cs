using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class Car
    {

        //Create a seperate class file called Car
        //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
        //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
        //The methods should take one string parameter: the respective noise property

        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        public void MakeEngineNoise(string engineNoise)
        {
            EngineNoise = engineNoise;
            Console.WriteLine($"{Make} {Model} as an engine noise that sounds like {EngineNoise}.");
        }
        public void MakeHonkNoise(string honkNoise)
        {
            HonkNoise = honkNoise;
            Console.WriteLine($"{Make} {Model} as an engine noise that sounds like {honkNoise}.");
        }
        public Car()
        {
            CarLot.NumberOfCars++;
        }

        public Car(string make, string model, int year, bool IsDriveable)
        {
            Make = make;
            Model = model;
            Year = year;
            IsDriveable = true;
            CarLot.NumberOfCars++;
        }
        public static int CarCounter()
        {
            Console.WriteLine($"Total number of cars {CarLot.NumberOfCars}");
            return CarLot.NumberOfCars;
        }
                               
    }
        //Now that the Car class is created we can instanciate 3 new cars
        //Set the properties for each of the cars
        //Call each of the methods for each car
}

