using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4SnakeAndLadder
{
    internal class UC5ExactWin
    {
        public void PlayerExactWin()
        {
            int playerPosition = 0;
            Random random = new Random();

            while (playerPosition != 100)
            {
                //generate roll
                int roll = random.Next(1, 7);
                //generate option
                int option = random.Next(0, 3);

                switch (option)
                {
                    case 0:
                        //no play
                        Console.WriteLine("Player choose not to play.");
                        break;
                    case 1:
                        if (playerPosition + roll > 100)
                        {
                            Console.WriteLine("Player choose not to play.");
                        }
                        else
                        {
                            playerPosition += roll;
                            Console.WriteLine("Player choose the ladder. Player new position is: {0}", playerPosition);

                        }
                        //ladder
                        break;
                    case 2:
                        playerPosition -= roll;
                        if (playerPosition < 0)
                        {
                            playerPosition = 0;
                        }
                        Console.WriteLine("Player choose the snake. Player new position is: {0}", playerPosition);
                        //snake
                        break;
                }
            }
        }
    }
}
