using System;
using System.Collections.Generic;
using System.Text;
using ModelLib.Interfaces;
using ModelLib.Types;

namespace ModelLib.Factories
{
    public class MonsterBehaviorFactory : IMonsterBehaviorFactory
    {
        public IMonsterBehavior CreateHostileBehavior()
        {
            throw new NotImplementedException();
        }

        public IMonsterBehavior CreateNeutralBehavior()
        {
            throw new NotImplementedException();
        }
    }
}
