using System;
using System.Collections.Generic;
using System.Text;
using ModelLib.Interfaces;

namespace GameLib.Models.NPC.Monsters.Behavior
{
    public class NeutralBehavior : IMonsterBehavior
    {
        // add attack if attacked
        // attack/defend methods
        public void Act()
        {
            Console.WriteLine("[Neutral] Hellooo");
        }
    }
}
