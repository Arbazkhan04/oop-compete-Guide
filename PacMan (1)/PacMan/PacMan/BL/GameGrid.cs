using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacMan.BL
{
    public class GameGrid
    {
        GameCell[,] gameCell;
        public int row;
        public int col;

        public GameGrid(string fileName, int rows, int cols)
        {
            this.row = rows;
            this.col = cols;
            gameCell = new GameCell[rows, cols];
            loadGrid(fileName);

        }

        private void loadGrid(string fileName)
        {
            StreamReader fp = new StreamReader(fileName);
            string record;
            for (int row = 0; row < this.row; row++)
            {
                record = fp.ReadLine();
                for (int col = 0; col < this.col; col++)
                {
                    GameCell cell = new GameCell(row, col, this);
                    gameObject gmaeObj = new gameObject(GameObjectType.Wall, record[col]);
                    cell.currentGameObject = gmaeObj;
                    gameCell[row, col] = cell;
                }
            }

        }
        public GameCell getCell(int x, int y)
        {
            return gameCell[x, y];
        }
    }
}
