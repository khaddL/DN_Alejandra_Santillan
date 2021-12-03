using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AudioManager;

namespace DN_1._2_Alejandra_Santillan_v1._0
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int intentos = 1;

            while (intentos <= 10)
            {


                    Console.WriteLine("Type the vehicle!");
                    string typevehicle = Console.ReadLine().ToLower();

                Vehicle vehicle = null;




                    switch (typevehicle)
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
                            System.Threading.Thread.Sleep(2000);

                              break;
 
                    }
                     
                    intentos++;

                if (vehicle != null)
                    {
                        vehicle.VehicleSound();
                    }



            }
             

            
        }
    }
}

