using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace PacMan.BL
{
    public class PacmanPlayer:gameObject
    {
        public PacmanPlayer(char displayCharacter, GameCell cell) : base(GameObjectType.Player,displayCharacter)
        {
            this.CurrentCell= cell;
        }

        public GameCell move(GameDirection direction)
        {
            return this.CurrentCell.nextCell(direction);
        }
    }
}
