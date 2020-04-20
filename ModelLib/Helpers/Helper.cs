using System;
using System.Collections.Generic;
using System.Text;
using ModelLib.Types;

namespace GameLib.Helpers
{
    public class Helper
    {
        // readonly, should give better random results...
        private readonly Random r = new Random();

        /// <summary>
        /// Random position value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public int PosRan(int value)
        {
            int i = r.Next(value);
            return i;
        }

        /// <summary>
        /// ´Can be used for new direction
        /// </summary>
        public void CreatureMovement()
        {
            // random selection of direction enum (up, down, left, right)
            Array directions = Enum.GetValues(typeof(Direction));
            Random r = new Random();
            Direction d = (Direction)directions.GetValue(r.Next(directions.Length));

        }
    }
}
