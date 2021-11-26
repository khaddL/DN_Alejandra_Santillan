using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AudioManager;

namespace DN_1._1_Jorge_Serna_v1._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Type the vehicle!");
                string animalType = Console.ReadLine().ToLower();

                Vehicle vehicle = null;

                switch (animalType)
                {
                    case "car":
                        vehicle = new Car();
                        break;
                    case "bus":
                        vehicle = new Bus();
                        break;
                    case "train":
                        vehicle = new Train();
                        break;

                    default:
                        Console.WriteLine("Vehicle not found!");
                        break;
                }

                if (vehicle != null)
                {
                    vehicle.VehicleSound();
                }
            }
        }
    }
}
