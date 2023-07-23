namespace E_commernece_app
{
    partial class userTrendingProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            pDataGV = new DataGridView();
            pictureBox1 = new PictureBox();
            updateGrpBox = new GroupBox();
            txtPIndex = new TextBox();
            button1 = new Button();
            lblPIndex = new Label();
            ((System.ComponentModel.ISupportInitialize)pDataGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            updateGrpBox.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(304, 20);
            label1.Name = "label1";
            label1.Size = new Size(213, 32);
            label1.TabIndex = 0;
            label1.Text = "Trending Product's";
            // 
            // pDataGV
            // 
            pDataGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            pDataGV.Location = new Point(79, 70);
            pDataGV.Name = "pDataGV";
            pDataGV.RowTemplate.Height = 25;
            pDataGV.Size = new Size(664, 227);
            pDataGV.TabIndex = 1;
            pDataGV.CellContentClick += dataGridView1_CellContentClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.back_button;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // updateGrpBox
            // 
            updateGrpBox.Controls.Add(txtPIndex);
            updateGrpBox.Controls.Add(button1);
            updateGrpBox.Controls.Add(lblPIndex);
            updateGrpBox.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            updateGrpBox.Location = new Point(79, 317);
            updateGrpBox.Name = "updateGrpBox";
            updateGrpBox.Size = new Size(664, 208);
            updateGrpBox.TabIndex = 3;
            updateGrpBox.TabStop = false;
            updateGrpBox.Text = "Let's Update The Product";
            updateGrpBox.Enter += updateGrpBox_Enter;
            // 
            // txtPIndex
            // 
            txtPIndex.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPIndex.Location = new Point(243, 67);
            txtPIndex.Name = "txtPIndex";
            txtPIndex.Size = new Size(266, 29);
            txtPIndex.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(15, 126);
            button1.Name = "button1";
            button1.Size = new Size(643, 43);
            button1.TabIndex = 8;
            button1.Text = "Buy Product";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblPIndex
            // 
            lblPIndex.AutoSize = true;
            lblPIndex.Location = new Point(15, 57);
            lblPIndex.Name = "lblPIndex";
            lblPIndex.Size = new Size(180, 37);
            lblPIndex.TabIndex = 8;
            lblPIndex.Text = "Product Index";
            // 
            // userTrendingProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 563);
            Controls.Add(updateGrpBox);
            Controls.Add(pictureBox1);
            Controls.Add(pDataGV);
            Controls.Add(label1);
            Name = "userTrendingProduct";
            Text = "userTrendingProduct";
            Load += userTrendingProduct_Load;
            ((System.ComponentModel.ISupportInitialize)pDataGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            updateGrpBox.ResumeLayout(false);
            updateGrpBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView pDataGV;
        private PictureBox pictureBox1;
        private GroupBox updateGrpBox;
        private TextBox txtPIndex;
        private Button button1;
        private Label lblPIndex;
    }
}