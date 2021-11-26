using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AudioManager;

namespace OOP.ConsoleExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            {
                Console.WriteLine("Type the animal!");

                string animalType = Console.ReadLine().ToLower();

                Animal animal = null;

                switch (animalType)
                {
                    case "cat":
                        animal = new Cat();
                        break;
                    case "cow":
                        animal = new Cow();
                        break;
                    case "elephant":
                        animal = new Elephant();
                        break;
                    case "lion":
                        animal = new Lion();
                        break;
                    case "pig":
                        animal = new Pig();
                        break;
                    case "dog":
                        animal = new Dog();
                        break;
                    default:
                        Console.WriteLine("Animal not found");
                        System.Threading.Thread.Sleep(2000);
                        Console.WriteLine();
                        break;
                }

                if (animal != null)
                {
                    animal.AnimalSound();
                }
            }

        }
    }
}
