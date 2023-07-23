namespace E_commernece_app
{
    partial class CreateProductForm
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
            groupBox1 = new GroupBox();
            button1 = new Button();
            lblCatagory = new Label();
            comboBox1 = new ComboBox();
            lblPQuantity = new Label();
            txtPQuantity = new TextBox();
            lblPPrice = new Label();
            txtPPrice = new TextBox();
            txtPName = new TextBox();
            lblPName = new Label();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(339, 47);
            label1.Name = "label1";
            label1.Size = new Size(171, 15);
            label1.TabIndex = 0;
            label1.Text = "welcome to the Create Product";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(lblCatagory);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(lblPQuantity);
            groupBox1.Controls.Add(txtPQuantity);
            groupBox1.Controls.Add(lblPPrice);
            groupBox1.Controls.Add(txtPPrice);
            groupBox1.Controls.Add(txtPName);
            groupBox1.Controls.Add(lblPName);
            groupBox1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(119, 95);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(621, 326);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Product Detail";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonFace;
            button1.Location = new Point(0, 274);
            button1.Name = "button1";
            button1.Size = new Size(610, 46);
            button1.TabIndex = 8;
            button1.Text = "Create Product";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lblCatagory
            // 
            lblCatagory.AutoSize = true;
            lblCatagory.Location = new Point(5, 221);
            lblCatagory.Name = "lblCatagory";
            lblCatagory.Size = new Size(152, 28);
            lblCatagory.TabIndex = 7;
            lblCatagory.Text = "Select Qatagory";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(172, 224);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(256, 29);
            comboBox1.TabIndex = 6;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // lblPQuantity
            // 
            lblPQuantity.AutoSize = true;
            lblPQuantity.Location = new Point(6, 164);
            lblPQuantity.Name = "lblPQuantity";
            lblPQuantity.Size = new Size(162, 28);
            lblPQuantity.TabIndex = 5;
            lblPQuantity.Text = "Product Quantity";
            // 
            // txtPQuantity
            // 
            txtPQuantity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPQuantity.Location = new Point(172, 167);
            txtPQuantity.Name = "txtPQuantity";
            txtPQuantity.Size = new Size(256, 29);
            txtPQuantity.TabIndex = 4;
            // 
            // lblPPrice
            // 
            lblPPrice.AutoSize = true;
            lblPPrice.Location = new Point(6, 111);
            lblPPrice.Name = "lblPPrice";
            lblPPrice.Size = new Size(128, 28);
            lblPPrice.TabIndex = 3;
            lblPPrice.Text = "Product Price";
            // 
            // txtPPrice
            // 
            txtPPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPPrice.Location = new Point(172, 111);
            txtPPrice.Name = "txtPPrice";
            txtPPrice.Size = new Size(256, 29);
            txtPPrice.TabIndex = 2;
            // 
            // txtPName
            // 
            txtPName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPName.Location = new Point(172, 55);
            txtPName.Name = "txtPName";
            txtPName.Size = new Size(256, 29);
            txtPName.TabIndex = 1;
            // 
            // lblPName
            // 
            lblPName.AutoSize = true;
            lblPName.Location = new Point(5, 56);
            lblPName.Name = "lblPName";
            lblPName.Size = new Size(138, 28);
            lblPName.TabIndex = 0;
            lblPName.Text = "Product Name";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.back_button;
            pictureBox1.Location = new Point(22, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // CreateProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "CreateProductForm";
            Text = "CreateProductForm";
            Load += CreateProductForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtPName;
        private Label lblPName;
        private TextBox txtPPrice;
        private TextBox txtPQuantity;
        private Label lblPPrice;
        private ComboBox comboBox1;
        private Label lblPQuantity;
        private Button button1;
        private Label lblCatagory;
        private PictureBox pictureBox1;
    }
}