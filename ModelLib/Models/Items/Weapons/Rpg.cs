using System;
using System.Collections.Generic;
using System.Text;
using ModelLib.Abstract;

namespace ModelLib.Models.Items.Weapons
{
    public class Rpg : WeaponAbstract
    {
        public override string Name
        {
            get { return "RPG Rocket Launcher"; }
        }

        public override double Damage
        {
            get { return 80; }
        }
    }
}
