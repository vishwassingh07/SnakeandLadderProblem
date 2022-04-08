using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeandLadderProblem
{
    public class SnakeandLadder
    {
        const int NO_PLAY = 0, SNAKE = 1, LADDER = 2;
        int position = 0;
        public int DieRoll()
        {
            Random random = new Random();
            int diePosition = random.Next(1, 7);
            return diePosition;
        }
        public void Game()
        {
            Random random = new Random();
            int option = random.Next(0,3);
            switch (option)
            {
                case NO_PLAY:
                    break;
                case SNAKE:this.position -= this.DieRoll();
                    break;
                case LADDER:this.position += this.DieRoll();
                    break;
            }
        }
    }
}
