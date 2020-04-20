using System;
using System.Collections.Generic;
using System.Text;
using GameLib.Abstract;
using GameLib.Models.World;
using GameLib.Types;

namespace GameLib.Interfaces
{
    public interface IGameWorldObjectFactory
    {
        GameWorldObjectAbstract Create(GameWorldObjects gameWorldObject);
    }
}
