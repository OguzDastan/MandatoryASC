using System;
using System.Collections.Generic;
using System.Text;
using ModelLib.Interfaces;

namespace ModelLib.Abstract
{
    public abstract class WeaponAbstract : IWeapon
    {
        public abstract string Name { get; }
        public abstract double Damage { get; }

        // public abstract int PosX { get; }
        // public abstract int PosY { get; }

        public override string ToString()
        {
            return $"{Name}, dealing {Damage} damage points";
        }

    }
}
