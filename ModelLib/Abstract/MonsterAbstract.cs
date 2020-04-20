using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using GameLib.Abstract;
using GameLib.Helpers;
using GameLib.Models.NPC.Monsters.Behavior;
using ModelLib.Interfaces;
using ModelLib.Models.Items;
using ModelLib.Models.NPC.Monsters.Behavior;
using ModelLib.Types;

namespace ModelLib.Abstract
{
    public abstract class MonsterAbstract : IMonster
    {
        #region fields
        //
        private Helper h = new Helper();

        public Dictionary<MonsterState, IMonsterBehavior> Behaviors = new Dictionary<MonsterState, IMonsterBehavior>();

        #endregion

        #region properties



        public Vector2 Position
        {
            get { return new Vector2(h.PosRan(9), h.PosRan(9)); }
            set { }
        }
        public bool IsDead
        {
            get { return IsDeadChecker(); }
            set
            {

            }
        }
        public Direction Direction
        {
            get { return RandomDirection(); }
            set { }
        }
        public string Name { get; set; }
        public double Hitpoints { get; set; }
        public double Damage { get; set; }
        public char MonsterChar { get; set; }
        public ArmorType Armor { get; set; }
        public WeaponType Weapon { get; set; }
        public MonsterState CurrentState { get; set; }

        #endregion

        #region methods

        public Direction RandomDirection()
        {
            Random r = new Random();
            Array dir = Enum.GetValues(typeof(Direction));
            Direction d = (Direction)dir.GetValue(r.Next(0, dir.Length));
            return d;
        }

        public bool IsDeadChecker()
        {
            if (Hitpoints <= 0)
            {
                Console.WriteLine(Name + " was killed!");
                return IsDead = true;
            }

            return false;
        }
        public void Movement()
        {
            Random r = new Random();
            int x = r.Next(1, 2);
            int y = r.Next(1, 2);

            Position = new Vector2(x, y);
        }

        public void InteractCreature(MonsterAbstract monster)
        {
            if (monster.Position == Position && Name != monster.Name)
            {
                if (monster.CurrentState == MonsterState.Hostile)
                {
                    Attack(this, monster);
                }
                else if (monster.CurrentState == MonsterState.Neutral)
                {
                    Console.WriteLine("Hello, my name is " + monster.Name);
                }
            }
        }

        public void InteractItem(GameWorldObjectAbstract obj)
        {
            if (obj.Position == Position)
            {
                obj.UseObject(this);
            }
        }

        public void Attack(MonsterAbstract a, MonsterAbstract b)
        {
            if (a.CurrentState == MonsterState.Hostile || b.CurrentState == MonsterState.Hostile)
            {
                Console.WriteLine(a.Name + " is attacking " + b.Name + "!!!!");

                if (a.Damage < b.Hitpoints)
                {
                    double newHitpoints = a.Hitpoints -= b.Damage;
                    b.Hitpoints = newHitpoints;

                    Console.WriteLine(b.Name + " has taken " + a.Damage + " damage!");
                    Console.WriteLine(b.Name + " has " + b.Hitpoints + " hp left!");
                }
                else if (a.Damage > b.Hitpoints)
                {
                    b.Hitpoints = 0;

                    Console.WriteLine(b.Name + " Died!");
                }
            }
            else if (a.CurrentState == MonsterState.Neutral && b.CurrentState == MonsterState.Neutral)
            {
                Console.WriteLine("Oh sorry to bother you!");
            }
        }

        public override string ToString()
        {
            return $"{nameof(Position)}: {Position}, {nameof(Hitpoints)}: {Hitpoints}, " +
                   $"{nameof(Damage)}: {Damage}, {nameof(Name)}: {Name}, {nameof(IsDead)}: {IsDead}, " +
                   $"{nameof(MonsterChar)}: {MonsterChar}, {nameof(Armor)}: {Armor}, {nameof(Weapon)}:" +
                   $" {Weapon}, {nameof(Direction)}: {Direction}";
        }

        // method for setting behavior through state

        public void SetState(MonsterState state)
        {
            CurrentState = state;
        }

        public void SetBehavior(MonsterState state, IMonsterBehavior behavior)
        {
            Behaviors[state] = behavior;

        }

        // method for acting on state e.g. Hostile = Attack
        public void Act()
        {
            if (Behaviors.ContainsKey(CurrentState))
            {
                Behaviors[CurrentState].Act();
            }
            else
            {
                throw new Exception($"No behavior defined for state {CurrentState}");
            }
        }

        #endregion

        #region constructor

        public MonsterAbstract()
        {

        }

        #endregion


    }
}
