using System;
using System.Collections.Generic;
using System.Text;
using Modul_2_Practice_2.Model.BiologicalKingdom.KingdomAnimalia;

namespace Modul_2_Practice_2.Model.BiologicalKingdom.KingdomAnimalia
{
    public class Animal : FamilyOfAnimal
    {
        private Enum.FamilyOfAnimal _family;
        private Enum.Animal _kindOfAnimal;
        private Enum.SquadOfAnimal _squad;
        private Enum.AnimalClass _class;

        public Animal(Enum.Animal animal)
        {
            _kindOfAnimal = animal;
        }

        public Enum.Animal KindOfAnimal
        {
            get
            {
                return _kindOfAnimal;
            }

            set
            {
                switch (value)
                {
                    case Enum.Animal.Alligator:
                        Family = Enum.FamilyOfAnimal.Crocodylidae;
                        break;
                    case Enum.Animal.Gorilla:
                        Family = Enum.FamilyOfAnimal.Hominidae;
                        break;
                    case Enum.Animal.Marabu:
                        Family = Enum.FamilyOfAnimal.Stork;
                        break;
                    case Enum.Animal.Lion:
                        Family = Enum.FamilyOfAnimal.Catlike;
                        break;
                    case Enum.Animal.Tilapia:
                        Family = Enum.FamilyOfAnimal.Tilapias;
                        break;
                    case Enum.Animal.Zebra:
                        Family = Enum.FamilyOfAnimal.Equidae;
                        break;
                }

                _kindOfAnimal = value;
            }
        }

        public override Enum.FamilyOfAnimal Family
        {
            get
            {
                return _family;
            }

            set
            {
                switch (value)
                {
                    case Enum.FamilyOfAnimal.Crocodylidae:
                        Squad = Enum.SquadOfAnimal.Crocodile;
                        break;
                    case Enum.FamilyOfAnimal.Hominidae:
                        Squad = Enum.SquadOfAnimal.Primates;
                        break;
                    case Enum.FamilyOfAnimal.Stork:
                        Squad = Enum.SquadOfAnimal.CraneLike;
                        break;
                    case Enum.FamilyOfAnimal.Catlike:
                        Squad = Enum.SquadOfAnimal.Predatory;
                        break;
                    case Enum.FamilyOfAnimal.Tilapias:
                        Squad = Enum.SquadOfAnimal.Cichliformes;
                        break;
                    case Enum.FamilyOfAnimal.Equidae:
                        Squad = Enum.SquadOfAnimal.ClovenFooted;
                        break;
                }

                _family = value;
            }
        }

        public override Enum.SquadOfAnimal Squad
        {
            get
            {
                return _squad;
            }

            set
            {
                switch (value)
                {
                    case Enum.SquadOfAnimal.Crocodile:
                        Class = Enum.AnimalClass.Reptilia;
                        break;
                    case Enum.SquadOfAnimal.Primates:
                        Class = Enum.AnimalClass.Mammalia;
                        break;
                    case Enum.SquadOfAnimal.CraneLike:
                        Class = Enum.AnimalClass.Birds;
                        break;
                    case Enum.SquadOfAnimal.Predatory:
                        Class = Enum.AnimalClass.Mammalia;
                        break;
                    case Enum.SquadOfAnimal.Cichliformes:
                        Class = Enum.AnimalClass.Fish;
                        break;
                    case Enum.SquadOfAnimal.ClovenFooted:
                        Class = Enum.AnimalClass.Mammalia;
                        break;
                }

                _squad = value;
            }
        }

        public override Enum.AnimalClass Class
        {
            get { return _class; }
            set { _class = value; }
        }
    }
}
