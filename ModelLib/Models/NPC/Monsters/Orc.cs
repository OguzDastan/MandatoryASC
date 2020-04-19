using System;
using System.Collections.Generic;
using System.Text;
using ModelLib.Abstract;
using ModelLib.Interfaces;
using ModelLib.Types;

namespace ModelLib.Models.NPC.Monsters
{
    public class Orc : MonsterAbstract
    {
        public Orc()
        {
            
        }
        // standard constructor
        public Orc(string name, double hp, WeaponType weapon, ArmorType armor, int posX, int posY, Direction direction, MonsterState state) : base(name, state, hp, weapon, armor, posX, posY, direction)
        {

        }

        // constructor with behavior factory
        public Orc(string name, MonsterState initialState, IMonsterBehaviorFactory factory, double hp, WeaponType weapon, ArmorType armor, int posX, int posY, Direction direction) : base(name, initialState, hp, weapon, armor, posX, posY, direction)
        {
            
        }
    }
}
