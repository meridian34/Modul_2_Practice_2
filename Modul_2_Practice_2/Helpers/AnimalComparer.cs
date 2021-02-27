using System.Collections;
using Modul_2_Practice_2.Model.BiologicalKingdom.KingdomAnimalia;

namespace Modul_2_Practice_2.Helpers
{
    public class AnimalComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            var animal1 = x as Animal;
            var animal2 = x as Animal;
            var kingdomCompareValue = KingdomCompare(animal1, animal2);
            var typeCompareValue = TypeCompare(animal1, animal2);
            var classCompareValue = ClassCompare(animal1, animal2);
            var squadCompareValue = SquadCompare(animal1, animal2);
            var familyCompareValue = FamilyCompare(animal1, animal2);
            var kindOfAnimalCompareValue = KindOfAnimalCompare(animal1, animal2);

            if (kingdomCompareValue != 0)
            {
                return kingdomCompareValue;
            }
            else if (typeCompareValue != 0)
            {
                return typeCompareValue;
            }
            else if (classCompareValue != 0)
            {
                return classCompareValue;
            }
            else if (squadCompareValue != 0)
            {
                return squadCompareValue;
            }
            else if (familyCompareValue != 0)
            {
                return familyCompareValue;
            }
            else if (kindOfAnimalCompareValue != 0)
            {
                return kindOfAnimalCompareValue;
            }

            return 0;
        }

        private int KingdomCompare(Animal x, Animal y)
        {
            if (x.KindOfAnimal > y.KindOfAnimal)
            {
                return 1;
            }
            else if (x.KindOfAnimal < y.KindOfAnimal)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        private int TypeCompare(Animal x, Animal y)
        {
            if (x.Type > y.Type)
            {
                return 1;
            }
            else if (x.Type < y.Type)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        private int ClassCompare(Animal x, Animal y)
        {
            if (x.Class > y.Class)
            {
                return 1;
            }
            else if (x.Class < y.Class)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        private int SquadCompare(Animal x, Animal y)
        {
            if (x.Squad > y.Squad)
            {
                return 1;
            }
            else if (x.Squad < y.Squad)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        private int FamilyCompare(Animal x, Animal y)
        {
            if (x.Family > y.Family)
            {
                return 1;
            }
            else if (x.Family < y.Family)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        private int KindOfAnimalCompare(Animal x, Animal y)
        {
            if (x.KindOfAnimal > y.KindOfAnimal)
            {
                return 1;
            }
            else if (x.KindOfAnimal < y.KindOfAnimal)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
