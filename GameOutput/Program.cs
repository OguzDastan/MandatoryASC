using System;
using GameLib.Models.NPC.Monsters.Behavior;
using ModelLib.Models;
using ModelLib.Models.Items;
using ModelLib.Models.NPC.Monsters;
using ModelLib.Models.NPC.Monsters.Behavior;
using ModelLib.Types;

namespace GameOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            Orc o = new Orc("Orc", 100, WeaponType.Melee, ArmorType.Heavy, 1,1, CreatureMovement(), MonsterState.Neutral);

            Console.WriteLine("Name:" + o.Name + "\nState:" + o.CurrentState + "\nWeapon:" + o.WeaponType + "\nArmor:" + o.ArmorType + "\nPosition X:" + o.PositionX + " - Position Y:" + o.PositionY + "\nDirection:" + o.CreatureDirection + "\nState:" + o.CurrentState);
            // o.SetBehavior(MonsterState.Hostile, new HostileBehavior());
            o.Act();

        }

        // random direction array to assign starting direction of Creature
        public static Direction CreatureMovement()
        {
            // random selection of direction enum (up, down, left, right)
            Array directions = Enum.GetValues(typeof(Direction));
            Random r = new Random();
            Direction d = (Direction)directions.GetValue(r.Next(directions.Length));
            return d;
        }
    }
}
