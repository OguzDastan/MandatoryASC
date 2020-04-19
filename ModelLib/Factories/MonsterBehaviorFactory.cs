using System;
using System.Collections.Generic;
using System.Text;
using GameLib.Models.NPC.Monsters.Behavior;
using ModelLib.Interfaces;
using ModelLib.Models.NPC.Monsters.Behavior;
using ModelLib.Types;

namespace ModelLib.Factories
{
    public class MonsterBehaviorFactory : IMonsterBehaviorFactory
    {
        public IMonsterBehavior CreateHostileBehavior()
        {
            return new HostileBehavior();
        }

        public IMonsterBehavior CreateNeutralBehavior()
        {
            return new NeutralBehavior();
        }
    }
}
