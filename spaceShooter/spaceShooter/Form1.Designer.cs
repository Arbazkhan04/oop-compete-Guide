namespace spaceShooter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pbPlayerShip1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pbPlayerShip1).BeginInit();
            SuspendLayout();
            // 
            // pbPlayerShip1
            // 
            pbPlayerShip1.BackColor = Color.Transparent;
            pbPlayerShip1.Image = Properties.Resources.player;
            pbPlayerShip1.Location = new Point(372, 337);
            pbPlayerShip1.Name = "pbPlayerShip1";
            pbPlayerShip1.Size = new Size(116, 74);
            pbPlayerShip1.SizeMode = PictureBoxSizeMode.Zoom;
            pbPlayerShip1.TabIndex = 0;
            pbPlayerShip1.TabStop = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            ClientSize = new Size(924, 511);
            Controls.Add(pbPlayerShip1);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pbPlayerShip1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbPlayerShip1;
        private System.Windows.Forms.Timer timer1;
    }
}