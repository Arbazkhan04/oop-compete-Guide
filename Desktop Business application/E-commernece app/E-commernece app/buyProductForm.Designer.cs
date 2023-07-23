namespace E_commernece_app
{
    partial class buyProductForm
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
            pictureBox1 = new PictureBox();
            pDataGV = new DataGridView();
            updateGrpBox = new GroupBox();
            txtPIndex = new TextBox();
            btnBuy = new Button();
            lblPIndex = new Label();
            txtUpdatedPQuantty = new Label();
            txtUpdatedPquantity = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pDataGV).BeginInit();
            updateGrpBox.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.back_button;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pDataGV
            // 
            pDataGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            pDataGV.Location = new Point(133, 26);
            pDataGV.Name = "pDataGV";
            pDataGV.RowTemplate.Height = 25;
            pDataGV.Size = new Size(581, 192);
            pDataGV.TabIndex = 1;
            pDataGV.CellContentClick += dataGridView1_CellContentClick;
            // 
            // updateGrpBox
            // 
            updateGrpBox.Controls.Add(txtPIndex);
            updateGrpBox.Controls.Add(btnBuy);
            updateGrpBox.Controls.Add(lblPIndex);
            updateGrpBox.Controls.Add(txtUpdatedPQuantty);
            updateGrpBox.Controls.Add(txtUpdatedPquantity);
            updateGrpBox.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            updateGrpBox.Location = new Point(127, 232);
            updateGrpBox.Name = "updateGrpBox";
            updateGrpBox.Size = new Size(587, 267);
            updateGrpBox.TabIndex = 2;
            updateGrpBox.TabStop = false;
            updateGrpBox.Text = "Let's buy the product";
            // 
            // txtPIndex
            // 
            txtPIndex.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPIndex.Location = new Point(243, 67);
            txtPIndex.Name = "txtPIndex";
            txtPIndex.Size = new Size(247, 29);
            txtPIndex.TabIndex = 9;
            // 
            // btnBuy
            // 
            btnBuy.Location = new Point(6, 188);
            btnBuy.Name = "btnBuy";
            btnBuy.Size = new Size(546, 43);
            btnBuy.TabIndex = 8;
            btnBuy.Text = "Buy Product";
            btnBuy.UseVisualStyleBackColor = true;
            btnBuy.Click += button1_Click;
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
            // txtUpdatedPQuantty
            // 
            txtUpdatedPQuantty.AutoSize = true;
            txtUpdatedPQuantty.Location = new Point(6, 121);
            txtUpdatedPQuantty.Name = "txtUpdatedPQuantty";
            txtUpdatedPQuantty.Size = new Size(218, 37);
            txtUpdatedPQuantty.TabIndex = 5;
            txtUpdatedPQuantty.Text = "Product Quantity";
            // 
            // txtUpdatedPquantity
            // 
            txtUpdatedPquantity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUpdatedPquantity.Location = new Point(243, 121);
            txtUpdatedPquantity.Name = "txtUpdatedPquantity";
            txtUpdatedPquantity.Size = new Size(247, 29);
            txtUpdatedPquantity.TabIndex = 4;
            // 
            // buyProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(864, 576);
            Controls.Add(updateGrpBox);
            Controls.Add(pDataGV);
            Controls.Add(pictureBox1);
            Name = "buyProductForm";
            Text = "buyProductForm";
            Load += buyProductForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pDataGV).EndInit();
            updateGrpBox.ResumeLayout(false);
            updateGrpBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private DataGridView pDataGV;
        private GroupBox updateGrpBox;
        private TextBox txtPIndex;
        private Button btnBuy;
        private Label lblPIndex;
        private Label txtUpdatedPQuantty;
        private TextBox txtUpdatedPquantity;
    }
}