using System;
using System.Collections.Generic;
using System.Text;

namespace Modul_2_Practice_2.Model.BiologicalKingdom.KingdomAnimalia
{
    public abstract class FamilyOfAnimal : SquadOfAnimal
    {
        public FamilyOfAnimal()
        {
        }

        public abstract Enum.FamilyOfAnimal Family { get; set; }
    }
}
