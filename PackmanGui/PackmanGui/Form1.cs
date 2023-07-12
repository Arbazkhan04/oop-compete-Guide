using EZInput;
using PackmanGui.GameGL;
using PacMan.GameGL;
using System.Threading;
using System.Net.WebSockets;
using System.Runtime.CompilerServices;
using System.Web;
using System.Reflection.Metadata.Ecma335;

namespace PackmanGui
{
    public partial class Form1 : Form
    {
        GamePacManPlayer pacman;
        private List<Ghost> ghostList = new List<Ghost>();

        //int score = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            GameGrid grid = new GameGrid("C:\\Users\\Arbaz khan\\OneDrive\\Desktop\\oop-compete-Guide\\PackmanGui\\PackmanGui\\bin\\Debug\\maze.txt", 24, 71);
            Image pacManImage = Game.getGameObjectImage('P');
            GameCell startCell = grid.getCell(8, 10);
            pacman = new GamePacManPlayer(pacManImage, startCell);
            //horizatal ghsot
            GameCell hCell = grid.getCell(13, 12);
            Image horizantalGhost = Game.getGameObjectImage('h');
            HorizantalGhost hGhost = new HorizantalGhost(horizantalGhost, hCell, GameDirection.Right);

            //vetical ghsot

            GameCell vCell = grid.getCell(1, 25);
            Image vImg = Game.getGameObjectImage('v');
            verticleGhost vGhost = new verticleGhost(vImg, vCell, GameDirection.Up);

            //random ghost
            GameCell rCell = grid.getCell(10, 30);
            Image rImg = Game.getGameObjectImage('r');
            randomGhost rGhost = new randomGhost(rImg, rCell, GameDirection.Down);

            ghostList.Add(hGhost);
            ghostList.Add(vGhost);
            ghostList.Add(rGhost);
            printMaze(grid);
        }

        void printMaze(GameGrid grid)
        {
            for (int x = 0; x < grid.Rows; x++)
            {

                for (int y = 0; y < grid.Cols; y++)
                {
                    GameCell cell = grid.getCell(x, y);
                    this.Controls.Add(cell.PictureBox);

                }

            }
        }
        private void gameLoop_Tick(object sender, EventArgs e)
        {
            if (Keyboard.IsKeyPressed(Key.LeftArrow))
            {
                pacman.move(GameDirection.Left);
            }
            if (Keyboard.IsKeyPressed(Key.RightArrow))
            {
                pacman.move(GameDirection.Right);
            }
            if (Keyboard.IsKeyPressed(Key.UpArrow))
            {
                pacman.move(GameDirection.Up);
            }
            if (Keyboard.IsKeyPressed(Key.DownArrow))
            {
                pacman.move(GameDirection.Down);
            }

            /* if(pacman.checkPackmanEatPallet())
             {
                 MessageBox.Show("eating");
                 score++;
             }
            */
            label1.Text = pacman.Score.ToString();

            foreach (Ghost ghost in ghostList)
            {
                if (checkPackmanCollidWithGhost(ghost.move())) //terminate the game here 
                {

                    MessageBox.Show(pacman.Score.ToString());
                }
            }
        }

        private bool checkPackmanCollidWithGhost(GameCell nextcell)
        {
            if (pacman.CurrentCell.X == nextcell.X && pacman.CurrentCell.Y == nextcell.Y)
            {
                return true;
            }
            return false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}