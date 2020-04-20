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
            set { }
        }

        public override double Defence
        {
            get { return 50; }
            set { }
        }

        public override string Name
        {
            get { return "Heavy Armor"; }
            set { }
        }

        public Heavy(string name, double defence)
        {
            Name = name;
            Defence = defence;
        }
    }
}
