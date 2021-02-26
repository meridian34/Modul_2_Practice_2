using System;
using System.Collections.Generic;
using System.Text;
using Modul_2_Practice_2.Model.Enum;

namespace Modul_2_Practice_2.Model.BiologicalKingdom.KingdomAnimalia
{
    public abstract class TypeOfAnimal : BiologicalKingdom
    {
        public TypeOfAnimal()
        {
            Kingdom = Enum.BiologicalKingdom.KingdomAnimalia;
        }

        public override Enum.BiologicalKingdom Kingdom { get; set; }

        public abstract Enum.TypeOfAnimal Type { get; set; }
    }
}
