using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using ModelLib.Abstract;

namespace GameLib.Interfaces
{
    public interface IGameWorldObject
    {
        void UseObject(MonsterAbstract m);
        Vector2 Position { get; set; }
        string Name { get; set; }
        bool isUsed { get; set; }
    }
}
