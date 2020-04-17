using System;
using System.Collections.Generic;
using System.Text;
using ModelLib.Abstract;

namespace ModelLib.Models.Items.Weapons
{
    public class Staff : WeaponAbstract
    {
        public override string Name
        {
            get { return "Mage Staff"; }
        }

        public override double Damage
        {
            get { return 60; }
        }
    }
}
