using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4SnakeAndLadder
{
    internal class UC6DiceRollCount
    {
        public void CountDiceRoll()
        {
            int playerPosition = 0;
            int rollCount = 0;
            Random random = new Random();

            while (playerPosition != 100)
                {
                    //generate roll
                    int roll = random.Next(1, 7);
                    rollCount++;
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
            Console.WriteLine("The number of Times the Dice was played to win the Game is: " + rollCount);   
        }
    }
}
