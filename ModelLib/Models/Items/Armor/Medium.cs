using System;
using System.Collections.Generic;
using System.Text;
using ModelLib.Abstract;
using ModelLib.Types;

namespace ModelLib.Models.Items.Armor
{
    public class Medium : ArmorAbstract
    {
        public override ArmorType ArmorType
        {
            get { return ArmorType.Medium; }
        }

        public override double Defence
        {
            get { return 25; }
        }

        public override string Name
        {
            get { return "Medium Armor"; }
        }
    }
}
