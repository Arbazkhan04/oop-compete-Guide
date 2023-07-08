using EZInput;

namespace spaceShooter
{
    public partial class Form1 : Form
    {
        public List<PictureBox> playerFires = new List<PictureBox>();

        Random rand = new Random();
        PictureBox enemyBlack;
        PictureBox enemyBlue;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            enemyBlack = createEnemy(spaceShooter.Properties.Resources.monster);
            this.Controls.Add(enemyBlack);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Keyboard.IsKeyPressed(Key.RightArrow))
            {
                pbPlayerShip1.Left = pbPlayerShip1.Left + 25;
            }

            if (Keyboard.IsKeyPressed(Key.LeftArrow))
            {
                pbPlayerShip1.Left = pbPlayerShip1.Left - 25;
            }

            if (Keyboard.IsKeyPressed(Key.Space))
            {
                Image fireImage = spaceShooter.Properties.Resources.fire;
                PictureBox pbFire = new PictureBox();
                pbFire.Image = fireImage;
                pbFire.Width = fireImage.Width;
                pbFire.Height = fireImage.Height;
                pbFire.BackColor = Color.Transparent;
                pbFire.Left = pbPlayerShip1.Left + (pbPlayerShip1.Width / 2) - 5;
                pbFire.Top = pbPlayerShip1.Top;
                playerFires.Add(pbFire);
                this.Controls.Add(pbFire);
            }
            foreach (PictureBox bullet in playerFires)
            {
                bullet.Top = bullet.Top - 20;
            }
            for (int idx = 0; idx < playerFires.Count; idx++)
            {
                if (playerFires[idx].Bottom < 0)
                {
                    playerFires.Remove(playerFires[idx]);
                }
            }

           
        }

        private PictureBox createEnemy(Image img)
        {
            PictureBox pbEnmey = new PictureBox();
            int left = rand.Next(30, this.Width);
            int top = rand.Next(5, img.Height + 20);
            pbEnmey.Left = left;
            pbEnmey.Top = top ;
            pbEnmey.Height = img.Height;
            pbEnmey.Width = img.Width;
            pbEnmey.BackColor = Color.Transparent;
            pbEnmey.Image = img;
            return pbEnmey;


        }
    }
}