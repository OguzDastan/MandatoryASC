using System;
using System.Collections.Generic;
using System.Text;
using ModelLib.Interfaces;
using ModelLib.Models.Items.Weapons;
using ModelLib.Types;

namespace ModelLib.Factories
{
    public class WeaponFactory : IWeaponFactory
    {
        public IWeapon Create(WeaponType type)
        {
            if (type == WeaponType.Ranged) return new Rpg();
            if (type == WeaponType.Melee) return new BoxingGloves();
            if (type == WeaponType.Magic) return new Staff();

            throw new ArgumentException($"Weapon Factory - No class available for that weapontype {type}");
        }
    }
}
