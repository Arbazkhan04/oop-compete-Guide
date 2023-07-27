using PacMan.GameGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spaceShooter.gameGl
{
    public class randomEnemy : gameEnemy
    {
        private GameObject previousGameObject;
        private int moveCounter;

        public randomEnemy(Image img, GameCell currentCell, GameDirection gameDirection) : base(img, currentCell, gameDirection)
        {
            moveCounter = 0;
        }

        public override GameCell move()
        {
            GameCell currentCell = this.CurrentCell;
            GameCell nextCell = currentCell.nextCell(gameDirection);
            previousGameObject = nextCell.CurrentGameObject;
            this.CurrentCell = nextCell;

            if (currentCell != nextCell)
            {
                currentCell.setGameObject(previousGameObject);
            }
            else
            {
                moveCounter++;

                if (moveCounter >= 3)
                {
                    moveCounter = 0;

                    // Generate a random number to choose a new direction
                    int randomNumber = generateRandomNumber();
                    switch (randomNumber)
                    {
                        case 0:
                            gameDirection = GameDirection.Up;
                            break;
                        case 1:
                            gameDirection = GameDirection.Down;
                            break;
                        case 2:
                            gameDirection = GameDirection.Left;
                            break;
                        case 3:
                            gameDirection = GameDirection.Right;
                            break;
                    }
                }
            }

            return currentCell;
        }

        private int generateRandomNumber()
        {
            Random random = new Random();
            int randomNumber = random.Next(4);
            return randomNumber;
        }
    }
}
