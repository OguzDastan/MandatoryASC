using System;
using System.Collections.Generic;
using System.Text;
using ModelLib.Interfaces;
using ModelLib.Models.Items;
using ModelLib.Types;

namespace ModelLib.Abstract
{
    public abstract class MonsterAbstract : IMonster
    {
        #region fields

        private double _basehitpoints = 100;

        #endregion

        #region properties

        // interface contract for GameObject, *currently no use*
        public int PositionX { get; set; }
        public int PositionY { get; set; }

        // IMonster contract
        public string Name { get; }
        public MonsterState CurrentState { get; set; }

        // dictionary for behaviors
        public Dictionary<MonsterState, IMonsterBehavior> Behaviors { get; set; }

        // standard properties
        public WeaponType WeaponType { get; set; }
        public ArmorType ArmorType { get; set; }
        public Direction CreatureDirection { get; set; }
        public bool IsDead { get; set; }

        public double Hitpoints
        {
            get => _basehitpoints;
            set
            {
                if (value <= 0)
                {
                    IsDead = true;
                }
                _basehitpoints = value;
            }
        }

        #endregion

        #region methods

        void Attack()
        {

        }


        // method for setting behavior through state
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


        public MonsterAbstract(string name, MonsterState state, double hp, WeaponType weapon, ArmorType armor, int posX, int posY, Direction direction)
        {
            Hitpoints = hp;
            Name = name;
            CurrentState = state;
            WeaponType = weapon;
            ArmorType = armor;
            CreatureDirection = direction;

            PositionX = posX;
            PositionY = posY;
        }

        #endregion


    }
}
