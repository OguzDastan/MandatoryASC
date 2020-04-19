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
            Orc a = new Orc(new NeutralBehavior(), new HostileBehavior() );
            Orc b = new Orc(new NeutralBehavior(), new HostileBehavior());

            a.SetBehavior(MonsterState.Neutral, new NeutralBehavior());
            b.SetBehavior(MonsterState.Neutral, new NeutralBehavior());

            Console.WriteLine("" + a.CurrentState + " " + b.CurrentState);

            a.Attack(a,b);


            a.Act();

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
