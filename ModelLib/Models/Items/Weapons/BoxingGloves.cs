using System;
using System.Collections.Generic;
using System.Text;
using ModelLib.Abstract;

namespace ModelLib.Models.Items.Weapons
{
    class BoxingGloves : WeaponAbstract
    {
        public override string Name
        {
            get { return "Boxing Gloves"; }
        }

        public override double Damage
        {
            get { return 50; }
        }
    }
}
