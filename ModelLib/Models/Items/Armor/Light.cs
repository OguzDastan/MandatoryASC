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
        }

        public override string Name
        {
            get
            {
                return "Light Armor";
            }
        }

        public override double Defence
        {
            get { return 10; }
        }
    }
}
