﻿using PackmanGui.GameGL;
using PacMan.GameGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spaceShooter.gameGl
{
    public class verticleEnemy:gameEnemy
    {
        public GameObject previousGameObject;
        public verticleEnemy(Image img, GameCell currentCell, GameDirection gameDirection) : base(img, currentCell, gameDirection)
        {
        }

        public override GameCell move()
        {
            GameCell currentCell = this.CurrentCell;
            GameCell nextCell = currentCell.nextCell(gameDirection);

            if (nextCell != currentCell)
            {
                if (nextCell.CurrentGameObject.GameObjectType == GameObjectType.ENEMY)
                {
                    if (gameDirection == GameDirection.Down)
                    {
                        gameDirection = GameDirection.Up;
                    }
                    else
                    {
                        gameDirection = GameDirection.Down;
                    }
                }
                else
                {
                    currentCell.setGameObject(Game.getBlankGameObject());
                    this.CurrentCell = nextCell;
                }
            }
            else
            {
                if (gameDirection == GameDirection.Down)
                {
                    gameDirection = GameDirection.Up;
                }
                else
                {
                    gameDirection = GameDirection.Down;
                }
            }

            return currentCell;
        }

    }
}
