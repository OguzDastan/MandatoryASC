using System;
using System.Collections.Generic;
using System.Text;
using GameLib.Models.NPC.Monsters.Behavior;
using GameLib.Models.World;
using ModelLib.Factories;
using ModelLib.Interfaces;
using ModelLib.Models.NPC.Monsters;
using ModelLib.Models.NPC.Monsters.Behavior;
using ModelLib.Types;

namespace GameOutput
{
    public class Worker
    {
        Orc a = new Orc(MonsterState.Neutral, new NeutralBehavior(), new HostileBehavior());
        Orc b = new Orc(MonsterState.Neutral, new NeutralBehavior(), new HostileBehavior());

        public void Run()
        {
            // set behavior from state (hostile or neutral)
            // only outputs text
            a.SetBehavior(MonsterState.Neutral, new NeutralBehavior());

            // change state (hostile or neutral
            // only matters if attacking or getting attacked
            a.SetState(MonsterState.Hostile);

            // acts out with behavior from state (hostile = grrr, neutral = hello)
            a.Act();
            b.Act();

            // attack test
            a.Attack(a, b);

            Console.WriteLine("Current direction");
            Console.WriteLine(a.Direction);
            Console.WriteLine();
            Console.WriteLine("New direction");
            a.Direction = CreatureMovement();
            Console.WriteLine(a.Direction);

            Console.WriteLine();

            // factory test
            Console.WriteLine("Testing weapon factory");
            TestWeaponFactory(new WeaponFactory());

            Console.WriteLine();

            // factory test
            Console.WriteLine("Testing armor factory");
            TestArmorFactory(new ArmorFactory());
        }

        private static void TestWeaponFactory(IWeaponFactory factory)
        {
            IWeapon meleeWeapon = factory.Create(WeaponType.Melee);
            IWeapon rangedWeapon = factory.Create(WeaponType.Ranged);
            IWeapon magicWeapon = factory.Create(WeaponType.Magic);

            Console.WriteLine($"Melee weapon: {meleeWeapon}");
            Console.WriteLine($"Ranged weapon: {rangedWeapon}");
            Console.WriteLine($"Magic weapon: {magicWeapon}");
        }
        private static void TestArmorFactory(IArmorFactory factory)
        {
            IArmor heavyArmor = factory.Create(ArmorType.Heavy);
            IArmor lightArmor = factory.Create(ArmorType.Light);
            IArmor mediumArmor = factory.Create(ArmorType.Medium);

            Console.WriteLine($"Heavy weapon: {heavyArmor}");
            Console.WriteLine($"Light weapon: {lightArmor}");
            Console.WriteLine($"Medium weapon: {mediumArmor}");
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
