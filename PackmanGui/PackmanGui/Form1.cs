using EZInput;
using PackmanGui.GameGL;
using PacMan.GameGL;
using System.Runtime.CompilerServices;
using System.Web;

namespace PackmanGui
{
    public partial class Form1 : Form
    {
        GamePacManPlayer pacman;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            GameGrid grid = new GameGrid("C:\\Users\\Arbaz khan\\OneDrive\\Desktop\\oop-compete-Guide\\PackmanGui\\PackmanGui\\bin\\Debug\\maze.txt", 20, 70);
            Image pacManImage = Game.getGameObjectImage('P');
            GameCell startCell = grid.getCell(8, 10);
            pacman = new GamePacManPlayer(pacManImage, startCell);
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
        }
    }
}