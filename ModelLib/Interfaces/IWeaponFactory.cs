using System;
using System.Collections.Generic;
using System.Text;
using ModelLib.Types;

namespace ModelLib.Interfaces
{
    public interface IWeaponFactory
    {
        IWeapon Create(WeaponType type);
    }
}
