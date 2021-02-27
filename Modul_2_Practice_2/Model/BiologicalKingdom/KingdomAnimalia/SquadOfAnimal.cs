using System;
using System.Collections.Generic;
using System.Text;

namespace Modul_2_Practice_2.Model.BiologicalKingdom.KingdomAnimalia
{
    public abstract class SquadOfAnimal : AnimalClass
    {
        public SquadOfAnimal()
        {
        }

        public abstract Enum.SquadOfAnimal Squad { get; set; }
    }
}
