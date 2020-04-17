using System;
using System.Collections.Generic;
using System.Text;
using ModelLib.Types;

namespace ModelLib.Interfaces
{
    public interface IArmorFactory
    {
        IArmor Create(ArmorType type);
    }
}
