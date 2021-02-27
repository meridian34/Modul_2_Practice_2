using System;
using Modul_2_Practice_2.Helpers;
using Modul_2_Practice_2.Model.BiologicalKingdom.KingdomAnimalia;

namespace Modul_2_Practice_2.Model
{
    public class Location
    {
        private readonly Animal[] _animals;

        public Location(Animal[] animals)
        {
            _animals = animals;
            Array.Sort(_animals, new AnimalComparer());
        }

        public Animal[] GetAnimals()
        {
            return _animals;
        }
    }
}
