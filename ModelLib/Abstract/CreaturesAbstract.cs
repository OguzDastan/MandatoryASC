using System;
using System.Collections.Generic;
using System.Text;
using ModelLib.Interfaces;
using ModelLib.Models.Items;
using ModelLib.Types;

namespace ModelLib.Abstract
{
    public abstract class CreaturesAbstract : IGameObjects
    {
        #region fields

        private double _basehitpoints = 100;

        #endregion

        #region properties

        // interface contract
        public int PositionX { get; set; }
        public int PositionY { get; set; }

        // standard properties
        public string Name { get; set; }
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

        #region constructor

        public CreaturesAbstract(string name, double hp, WeaponType weapon, ArmorType armor, int posX, int posY, Direction direction)
        {
            Hitpoints = hp;
            Name = name;
            WeaponType = weapon;
            ArmorType = armor;
            CreatureDirection = direction;

            PositionX = posX;
            PositionY = posY;
        }

        #endregion
    }
}
