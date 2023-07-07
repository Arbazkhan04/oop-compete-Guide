using PacMan.GameGL;

namespace PackmanGui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PictureBox Player = new PictureBox();
            Player.Image = PackmanGui.Properties.Resources.pacman_close;
            Player.BackColor = Color.Transparent;

            GameGrid grid = new GameGrid("maze.txt", 23, 71);

            for (int x = 0; x < grid.Rows; x++)
            {

                for (int y = 0; y < grid.Cols; y++)
                {
                    GameCell cell = grid.getCell(x, y);
                    Console.SetCursorPosition(cell.Y, cell.X);
                    this.Controls.Add(cell.CurrentGameObject.Img());
                }

            }


        }

        private static void  printMaze(GameGrid grid)
        {
            for (int x = 0; x < grid.Rows; x++)
            {

                for (int y = 0; y < grid.Cols; y++)
                {
                    GameCell cell = grid.getCell(x, y);
                    printCell(cell);
                }

            }
        }

        static void printCell(GameCell cell)
        {
            Console.SetCursorPosition(cell.Y, cell.X);
            Console.Write(cell.CurrentGameObject.DisplayCharacter);
        }
    }
}