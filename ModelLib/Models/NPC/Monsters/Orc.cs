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
        public Orc(IMonsterBehavior hostileBehavior, IMonsterBehavior neutralBehavior)
        {
            Hitpoints = 100;
            Name = "Orc";
            MonsterChar = 'O';
            IsDead = false;
            Armor = ArmorType.Heavy;
            Weapon = WeaponType.Melee;
            CurrentState = MonsterState.Hostile;
            Damage = 15;


            //
            SetBehavior(MonsterState.Hostile, hostileBehavior);
            SetBehavior(MonsterState.Neutral, neutralBehavior);
        }
    }
}
