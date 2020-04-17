using System;
using System.Collections.Generic;
using System.Text;
using ModelLib.Types;

namespace ModelLib.Interfaces
{
    public interface IArmor
    {
        ArmorType ArmorType { get; }
        double Defence { get; }
        string Name { get; }
    }
}
