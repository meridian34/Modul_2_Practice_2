using System;
using System.Collections.Generic;
using System.Text;
using Modul_2_Practice_2.Model.Enum;

namespace Modul_2_Practice_2.Model.BiologicalKingdom
{
    public abstract class BiologicalKingdom
    {
        public BiologicalKingdom()
        {
        }

        public abstract Enum.BiologicalKingdom Kingdom { get; set; }
    }
}
