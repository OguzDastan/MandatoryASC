using System;
using System.Collections.Generic;
using System.Text;
using ModelLib.Abstract;
using ModelLib.Models.Items;
using ModelLib.Types;

namespace ModelLib.Models
{
    public class Creature : CreaturesAbstract
    {
        #region constructor
        
        public Creature(string name, int posX, int posY, WeaponType weapon, ArmorType armor, double hp, Direction dir) : base(name, hp, weapon, armor, posX, posY, dir)
        {
            // instance of state
            IsDead = false;
        }

        #endregion

        #region methods

        public void CreatureMovement()
        {
            // random selection of direction enum (up, down, left, right)
            Array directions = Enum.GetValues(typeof(Direction));
            Random r = new Random();
            Direction d = (Direction)directions.GetValue(r.Next(directions.Length));

        }

        #endregion
    }
}
