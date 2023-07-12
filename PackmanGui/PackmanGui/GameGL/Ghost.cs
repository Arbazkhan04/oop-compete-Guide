using PacMan.GameGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace PackmanGui.GameGL
{
    public abstract class Ghost:GameObject
    {
        protected GameDirection gameDirection;
        public Ghost(Image img, GameCell cell,GameDirection gameDirection) : base(GameObjectType.ENEMY, img)
        {
            this.CurrentCell = cell;
            this.gameDirection = gameDirection;
        }

        public abstract GameCell move();
    }
}
