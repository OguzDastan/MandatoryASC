using System;
using System.Collections.Generic;
using System.Text;
using ModelLib.Interfaces;
using ModelLib.Models.Items.Armor;
using ModelLib.Types;

namespace ModelLib.Factories
{
    public class ArmorFactory : IArmorFactory
    {
        public IArmor Create(ArmorType type)
        {
            if (type == ArmorType.Light) return new Light("Mages robes", 10);
            if (type == ArmorType.Medium) return new Medium();
            if (type == ArmorType.Heavy) return new Heavy("Gondor Footman Armor", 50);

            throw new ArgumentException($"Armor Factory - No class available for that armortype {type}");
        }
    }
}
