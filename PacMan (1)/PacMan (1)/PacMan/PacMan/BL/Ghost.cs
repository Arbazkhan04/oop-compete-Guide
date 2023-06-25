using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacMan.BL
{
    public abstract class Ghost:gameObject
    {
        public Ghost(char displayCharacter, GameCell cell) : base(GameObjectType.Enemy, displayCharacter)
        {
            this.CurrentCell = cell;
        }

        public abstract GameCell move();
    }
}
