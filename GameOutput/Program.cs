using System;
using GameLib.Abstract;
using GameLib.Models.NPC.Monsters.Behavior;
using ModelLib.Factories;
using ModelLib.Interfaces;
using ModelLib.Models;
using ModelLib.Models.Items;
using ModelLib.Models.NPC.Monsters;
using ModelLib.Models.NPC.Monsters.Behavior;
using ModelLib.Types;

namespace GameOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker w = new Worker();
            w.Run();

        }

        
    }
}
