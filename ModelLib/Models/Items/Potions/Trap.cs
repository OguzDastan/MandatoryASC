using System;
using System.Collections.Generic;
using System.Text;
using GameLib.Abstract;
using ModelLib.Abstract;

namespace GameLib.Models.Items.Potions
{
    public class Trap : GameWorldObjectAbstract
    {
        private readonly Random r = new Random();

        public override string Name { get; set; }

        public Trap()
        {
            Name = "Trap";
        }

        public override void UseObject(MonsterAbstract m)
        {
            if (isUsed == false)
            {
                // traps have variation in damage, 5 to 15
                Console.ForegroundColor = ConsoleColor.Red;
                double damage = r.Next(5, 10);
                m.Hitpoints -= damage;
                isUsed = true;
                Console.WriteLine($"{m.Name} stepped on a trap! He took {damage}");
            }
        }

    }
}
