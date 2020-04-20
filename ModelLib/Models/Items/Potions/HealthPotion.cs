using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using GameLib.Abstract;
using GameLib.Interfaces;
using ModelLib.Abstract;

namespace GameLib.Models.Items.Potions
{
    public class HealthPotion : GameWorldObjectAbstract
    {
        public override string Name { get; set; }

        public override void UseObject(MonsterAbstract m)
        {
            if (m.Hitpoints >= 100)
            {
                m.Hitpoints += 20;
                isUsed = true;

                // ensuring hitpoints dont exceed max value
                if (m.Hitpoints > 100)
                {
                    m.Hitpoints = 100;
                }

                Console.WriteLine($"{m.Name} got 20hp! - current hp {m.Hitpoints}");
                
            }
        }

    }
}
