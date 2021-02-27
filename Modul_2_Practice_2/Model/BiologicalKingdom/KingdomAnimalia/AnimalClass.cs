using System;
using System.Collections.Generic;
using System.Text;

namespace Modul_2_Practice_2.Model.BiologicalKingdom.KingdomAnimalia
{
    public abstract class AnimalClass : TypeOfAnimal
    {
        public AnimalClass()
        {
            Type = Enum.TypeOfAnimal.Chordates;
        }

        public override Enum.TypeOfAnimal Type { get; set; }

        public abstract Enum.AnimalClass Class { get; set; }
    }
}
