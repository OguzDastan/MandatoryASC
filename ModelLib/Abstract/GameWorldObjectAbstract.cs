using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using GameLib.Helpers;
using GameLib.Interfaces;
using ModelLib.Abstract;

namespace GameLib.Abstract
{
    public abstract class GameWorldObjectAbstract : IGameWorldObject
    {
        Helper h = new Helper();

        public abstract string Name { get; set; }
        public bool isUsed { get; set; }
        public Vector2 Position { get { return new Vector2(h.PosRan(9), h.PosRan(9)); } set { } }

        public abstract void UseObject(MonsterAbstract m);

        public override string ToString()
        {
            return $"{nameof(Position)}: {Position}, {nameof(Name)}: {Name}";
        }
    }
}
