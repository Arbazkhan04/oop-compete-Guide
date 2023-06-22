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
        public GameCell cell;
      public PacmanPlayer(char displayCharacter,GameCell cell):base(displayCharacter)
        {
            this.cell = cell;
        }
    }
}
