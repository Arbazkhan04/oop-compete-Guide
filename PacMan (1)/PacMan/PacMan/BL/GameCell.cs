using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PacMan.BL
{
    public class GameCell
    {
        public int x;
        public int y;
        public gameObject currentGameObject;
        public GameGrid gameGrid;

        public GameCell(int x, int y, GameGrid gameGrid)
        {
            this.x = x;
            this.y = y;
            this.gameGrid = gameGrid;
        }

        public void nextCell(GameDirection gameDirection)
        {

        }
    }

}
