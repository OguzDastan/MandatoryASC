using System;
using System.Collections.Generic;
using System.Text;

namespace ModelLib.Interfaces
{
    public interface IMonsterBehaviorFactory
    {
        IMonsterBehavior CreateHostileBehavior();
        IMonsterBehavior CreateNeutralBehavior();
    }
}
