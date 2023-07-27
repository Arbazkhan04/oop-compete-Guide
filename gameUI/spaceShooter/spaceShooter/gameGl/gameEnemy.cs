using PacMan.GameGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spaceShooter.gameGl
{
    public abstract class gameEnemy : GameObject
    {
        protected GameDirection gameDirection;
        public gameEnemy(Image img, GameCell cell, GameDirection gameDirection) : base(GameObjectType.ENEMY, img)
        {
            CurrentCell = cell;
            this.gameDirection = gameDirection;
        }

        public abstract GameCell move();
    }
}
