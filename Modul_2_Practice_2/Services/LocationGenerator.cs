using System;
using Modul_2_Practice_2.Model;
using Modul_2_Practice_2.Model.BiologicalKingdom.KingdomAnimalia;

namespace Modul_2_Practice_2.Services
{
    public class LocationGenerator : Abstract.ILocationGenerator
    {
        private readonly Random _random;
        private readonly int _minRandValue;
        private readonly int _maxRandValue;

        public LocationGenerator()
        {
            _minRandValue = 0;
            _maxRandValue = 6;
            _random = new Random();
        }

        public Location GenerateLocation(int maxAnimal)
        {
            var animals = new Animal[1];
            var currentSize = 0;
            var pointer = 0;

            while (currentSize <= maxAnimal)
            {
                switch (_random.Next(_minRandValue, _maxRandValue))
                {
                    case 0:
                        animals[pointer] = new Animal(Model.Enum.Animal.Lion);
                        break;
                    case 1:
                        animals[pointer] = new Animal(Model.Enum.Animal.Gorilla);
                        break;
                    case 2:
                        animals[pointer] = new Animal(Model.Enum.Animal.Alligator);
                        break;
                    case 3:
                        animals[pointer] = new Animal(Model.Enum.Animal.Marabu);
                        break;
                    case 4:
                        animals[pointer] = new Animal(Model.Enum.Animal.Tilapia);
                        break;
                    case 5:
                        animals[pointer] = new Animal(Model.Enum.Animal.Zebra);
                        break;
                }

                currentSize++;

                if (currentSize >= maxAnimal)
                {
                    break;
                }

                Array.Resize(ref animals, animals.Length + 1);
                pointer++;
            }

            return new Location(animals);
        }
    }
}
