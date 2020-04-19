using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using GameLib.Abstract;
using ModelLib.Abstract;
using ModelLib.Types;

namespace ModelLib.Interfaces
{
    public interface IMonster : IMonsterBehavior
    {
        #region Properties
        /// <summary>
        /// Name of monster
        /// </summary>
        string Name { get; }
        /// <summary>
        /// Position in the game world
        /// </summary>
        Vector2 Position { get; set; }
        /// <summary>
        /// Hitpoints of creatures
        /// </summary>
        double Hitpoints { get; set; }
        /// <summary>
        /// Damage on creatures
        /// </summary>
        double Damage { get; set; }
        /// <summary>
        /// Is dead or alive bool
        /// </summary>
        bool IsDead { get; set; }
        /// <summary>
        /// Character to represent monster in world
        /// </summary>
        char MonsterChar { get; set; }
        /// <summary>
        /// Armor of monster (light, medium, heavy)
        /// </summary>
        ArmorType Armor { get; }
        /// <summary>
        /// Weapon of creature
        /// </summary>
        WeaponType Weapon { get; }
        /// <summary>
        /// Which direction the monster goes
        /// </summary>
        Direction Direction { get; set; }
        /// <summary>
        /// Which state the monster is in (Hostile, Neutral)
        /// </summary>
        MonsterState CurrentState { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Set the behavior of monster (Hostile = attacks, Neutral = idle)
        /// </summary>
        /// <param name="state"></param>
        /// <param name="behavior"></param>
        void SetBehavior(MonsterState state, IMonsterBehavior behavior);
        
        /// <summary>
        /// Checker for dead/alive status
        /// </summary>
        /// <returns></returns>
        bool IsDeadChecker();

        /// <summary>
        /// Attack action. Monster A attacking monster B
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        void Attack(MonsterAbstract a, MonsterAbstract b);

        /// <summary>
        /// Interaction with other monster objects
        /// </summary>
        void InteractCreature(MonsterAbstract m);

        /// <summary>
        /// Interaction with item objects
        /// </summary>
        void InteractItem(GameWorldObjectAbstract obj);

        /// <summary>
        /// Random movement
        /// </summary>
        void Movement();

        #endregion

    }
}
