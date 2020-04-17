using System;
using System.Collections.Generic;
using System.Text;

namespace ModelLib.Interfaces
{
    public interface IWeapon
    {
        string Name { get; }
        double Damage { get; }
    }
}
