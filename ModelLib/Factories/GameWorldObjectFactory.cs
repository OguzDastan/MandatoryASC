using System;
using System.Collections.Generic;
using System.Text;
using GameLib.Abstract;
using GameLib.Interfaces;
using GameLib.Models.Items.Potions;
using GameLib.Types;

namespace GameLib.Factories
{
    public class GameWorldObjectFactory : IGameWorldObjectFactory
    {
        public GameWorldObjectAbstract Create(GameWorldObjects gameWorldObject)
        {
            if (gameWorldObject == GameWorldObjects.HealthPotion) return new HealthPotion();
            if (gameWorldObject == GameWorldObjects.Traps) return new Trap();

            throw new ArgumentException($"WorldObjectFactory - no object available with this nakme{gameWorldObject}");
        }
    }
}
