using System;
using System.Collections.Generic;
using System.Text;
using ModelLib.Abstract;
using ModelLib.Types;

namespace ModelLib.Models.Items.Armor
{
    public class Heavy : ArmorAbstract
    {
        public override ArmorType ArmorType
        {
            get { return ArmorType.Heavy; }
        }

        public override double Defence
        {
            get { return 50; }
        }

        public override string Name
        {
            get { return "Heavy Armor"; }
        }
    }
}
