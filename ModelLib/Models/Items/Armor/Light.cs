using System;
using System.Collections.Generic;
using System.Text;
using ModelLib.Abstract;
using ModelLib.Types;

namespace ModelLib.Models.Items.Armor
{
    public class Light : ArmorAbstract
    {
        public override ArmorType ArmorType
        {
            get { return ArmorType.Light; }
            set { }
        }

        public override string Name
        {
            get { return "Light Armor"; }
            set { }
        }

        public override double Defence
        {
            get { return 10; }
            set { }
        }
        public Light(string name, double defence)
        {
            Name = name;
            Defence = defence;
        }
    }
}
