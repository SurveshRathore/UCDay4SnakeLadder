using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4SnakeAndLadder
{
    internal class UC2SnakeLadderGameDieRoll
    {
        public void GenerateRoll ()
        {
            Random random = new Random();
            int roll = random.Next(1, 7);

            Console.WriteLine("The Player roll is: " + roll);
        }
    }
}
