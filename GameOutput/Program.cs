using System;
using ModelLib.Models;
using ModelLib.Models.Items;
using ModelLib.Types;

namespace GameOutput
{
    class Program
    {
        static void Main(string[] args)
        {


        }

        // random direction array to assign starting direction of Creature
        public static Direction CreatureMovement()
        {
            // random selection of direction enum (up, down, left, right)
            Array directions = Enum.GetValues(typeof(Direction));
            Random r = new Random();
            Direction d = (Direction)directions.GetValue(r.Next(directions.Length));
            return d;
        }
    }
}
