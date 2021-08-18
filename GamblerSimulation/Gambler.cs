using System;
using System.Collections.Generic;
using System.Text;

namespace GamblerSimulation
{
    class Gambler
    {
        public void Game()
        {
            int stack = 100;
            int bet = 1;
            Random random = new Random();
            int game = random.Next(0, 2);
            if (game == 1)
            {
                Console.WriteLine("Gamblem Won the Game ");
                stack += 1;
            }
            else
            {
                Console.WriteLine("Gamblem Lost the Game ");
                stack -= 1;
            }
            Console.WriteLine("Final Stack: " + stack);
        }
    }
}
