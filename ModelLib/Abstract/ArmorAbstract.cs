using System;
using System.Collections.Generic;
using System.Text;
using ModelLib.Interfaces;
using ModelLib.Types;

namespace ModelLib.Abstract
{
    public abstract class ArmorAbstract : IArmor
    {
        public abstract ArmorType ArmorType { get; set; }
        public abstract double Defence { get; set; }
        public abstract string Name { get; set; }

        public override string ToString()
        {
            return $"{ArmorType}, shield amount {Defence}";
        }
    }
}
