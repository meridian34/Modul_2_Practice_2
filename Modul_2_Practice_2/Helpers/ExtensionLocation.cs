using System;
using Modul_2_Practice_2.Model;
using Modul_2_Practice_2.Model.BiologicalKingdom.KingdomAnimalia;

namespace Modul_2_Practice_2.Helpers
{
    public static class ExtensionLocation
    {
        public static Animal FindAnimal(this Location location, Model.Enum.Animal animal)
        {
            foreach (var item in location.GetAnimals())
            {
                if (item.KindOfAnimal == animal)
                {
                    return item;
                }
            }

            return null;
        }

        public static void PrintCountOfDifferentAnimals(this Location location)
        {
            foreach (Model.Enum.Animal animal in Enum.GetValues(typeof(Model.Enum.Animal)))
            {
                Console.WriteLine($"{animal} : {GetCountAnimal(location, animal)}");
            }
        }

        private static int GetCountAnimal(this Location location, Model.Enum.Animal kindOfAnimal)
        {
            var count = 0;
            foreach (var item in location.GetAnimals())
            {
                if (kindOfAnimal == item.KindOfAnimal)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
