using System;
using Modul_2_Practice_2.Services;
using Modul_2_Practice_2.Helpers;

namespace Modul_2_Practice_2
{
    public class Starter
    {
        public void Run()
        {
            var generator = new LocationGenerator();
            var location = generator.GenerateLocation(30);
            foreach (var item in location.GetAnimals())
            {
                Console.WriteLine($"{item.Kingdom} {item.Type} {item.Class} {item.Squad} {item.Family} {item.KindOfAnimal}");
            }

            Console.WriteLine();

            var animal = location.FindAnimal(Model.Enum.Animal.Gorilla);
            if (animal != null)
            {
                Console.WriteLine("Animal find");
            }

            Console.WriteLine();

            location.PrintCountOfDifferentAnimals();
        }
    }
}
