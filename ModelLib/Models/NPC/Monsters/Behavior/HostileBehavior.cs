using System;
using System.Collections.Generic;
using System.Text;
using ModelLib.Interfaces;

namespace ModelLib.Models.NPC.Monsters.Behavior
{
    public class HostileBehavior : IMonsterBehavior
    {
        // add attack anyone on sight**
        // attack methods
        public void Act()
        {
            Console.WriteLine("[Hostile] Grrr...");
        }
    }
}
