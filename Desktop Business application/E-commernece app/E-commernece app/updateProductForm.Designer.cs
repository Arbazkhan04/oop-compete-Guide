namespace E_commernece_app
{
    partial class updateProductForm
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
            pDataGV = new DataGridView();
            updateGrpBox = new GroupBox();
            txtPIndex = new TextBox();
            button1 = new Button();
            lblPIndex = new Label();
            cbxUpdateProduct = new ComboBox();
            txtPCatagory = new Label();
            txtUpdatedPQuantty = new Label();
            txtUpdatedPquantity = new TextBox();
            txtUpdatedPPrice = new TextBox();
            label2 = new Label();
            txtUpdatePName = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pDataGV).BeginInit();
            updateGrpBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pDataGV
            // 
            pDataGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            pDataGV.Location = new Point(118, 12);
            pDataGV.Name = "pDataGV";
            pDataGV.RowTemplate.Height = 25;
            pDataGV.Size = new Size(546, 179);
            pDataGV.TabIndex = 0;
            pDataGV.CellContentClick += pDataGV_CellContentClick;
            // 
            // updateGrpBox
            // 
            updateGrpBox.Controls.Add(txtPIndex);
            updateGrpBox.Controls.Add(button1);
            updateGrpBox.Controls.Add(lblPIndex);
            updateGrpBox.Controls.Add(cbxUpdateProduct);
            updateGrpBox.Controls.Add(txtPCatagory);
            updateGrpBox.Controls.Add(txtUpdatedPQuantty);
            updateGrpBox.Controls.Add(txtUpdatedPquantity);
            updateGrpBox.Controls.Add(txtUpdatedPPrice);
            updateGrpBox.Controls.Add(label2);
            updateGrpBox.Controls.Add(txtUpdatePName);
            updateGrpBox.Controls.Add(label1);
            updateGrpBox.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            updateGrpBox.Location = new Point(99, 219);
            updateGrpBox.Name = "updateGrpBox";
            updateGrpBox.Size = new Size(587, 351);
            updateGrpBox.TabIndex = 1;
            updateGrpBox.TabStop = false;
            updateGrpBox.Text = "Let's Update The Product";
            updateGrpBox.Enter += groupBox1_Enter;
            // 
            // txtPIndex
            // 
            txtPIndex.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPIndex.Location = new Point(243, 67);
            txtPIndex.Name = "txtPIndex";
            txtPIndex.Size = new Size(247, 29);
            txtPIndex.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(15, 288);
            button1.Name = "button1";
            button1.Size = new Size(546, 43);
            button1.TabIndex = 8;
            button1.Text = "Update Product";
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
            // cbxUpdateProduct
            // 
            cbxUpdateProduct.AllowDrop = true;
            cbxUpdateProduct.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbxUpdateProduct.FormattingEnabled = true;
            cbxUpdateProduct.Location = new Point(243, 253);
            cbxUpdateProduct.Name = "cbxUpdateProduct";
            cbxUpdateProduct.Size = new Size(247, 29);
            cbxUpdateProduct.TabIndex = 7;
            cbxUpdateProduct.SelectedIndexChanged += cbxUpdateProduct_SelectedIndexChanged;
            // 
            // txtPCatagory
            // 
            txtPCatagory.AutoSize = true;
            txtPCatagory.Location = new Point(10, 245);
            txtPCatagory.Name = "txtPCatagory";
            txtPCatagory.Size = new Size(227, 37);
            txtPCatagory.TabIndex = 6;
            txtPCatagory.Text = "Product Qatagory";
            // 
            // txtUpdatedPQuantty
            // 
            txtUpdatedPQuantty.AutoSize = true;
            txtUpdatedPQuantty.Location = new Point(10, 196);
            txtUpdatedPQuantty.Name = "txtUpdatedPQuantty";
            txtUpdatedPQuantty.Size = new Size(218, 37);
            txtUpdatedPQuantty.TabIndex = 5;
            txtUpdatedPQuantty.Text = "Product Quantity";
            txtUpdatedPQuantty.Click += label3_Click;
            // 
            // txtUpdatedPquantity
            // 
            txtUpdatedPquantity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUpdatedPquantity.Location = new Point(243, 204);
            txtUpdatedPquantity.Name = "txtUpdatedPquantity";
            txtUpdatedPquantity.Size = new Size(247, 29);
            txtUpdatedPquantity.TabIndex = 4;
            // 
            // txtUpdatedPPrice
            // 
            txtUpdatedPPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUpdatedPPrice.Location = new Point(243, 159);
            txtUpdatedPPrice.Name = "txtUpdatedPPrice";
            txtUpdatedPPrice.Size = new Size(247, 29);
            txtUpdatedPPrice.TabIndex = 3;
            txtUpdatedPPrice.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 151);
            label2.Name = "label2";
            label2.Size = new Size(173, 37);
            label2.TabIndex = 2;
            label2.Text = "Product Price";
            label2.Click += label2_Click_1;
            // 
            // txtUpdatePName
            // 
            txtUpdatePName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUpdatePName.Location = new Point(243, 113);
            txtUpdatePName.Name = "txtUpdatePName";
            txtUpdatePName.Size = new Size(247, 29);
            txtUpdatePName.TabIndex = 1;
            txtUpdatePName.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 103);
            label1.Name = "label1";
            label1.Size = new Size(187, 37);
            label1.TabIndex = 0;
            label1.Text = "Product Name";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.back_button;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(73, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // updateProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 582);
            Controls.Add(pictureBox1);
            Controls.Add(updateGrpBox);
            Controls.Add(pDataGV);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "updateProductForm";
            Text = "updateProductForm";
            Load += updateProductForm_Load;
            ((System.ComponentModel.ISupportInitialize)pDataGV).EndInit();
            updateGrpBox.ResumeLayout(false);
            updateGrpBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView pDataGV;
        private GroupBox updateGrpBox;
        private TextBox txtUpdatePName;
        private Label label1;
        private Label label2;
        private TextBox txtUpdatedPPrice;
        private Label txtUpdatedPQuantty;
        private TextBox txtUpdatedPquantity;
        private ComboBox cbxUpdateProduct;
        private Label txtPCatagory;
        private Button button1;
        private PictureBox pictureBox1;
        private Label lblPIndex;
        private TextBox txtPIndex;
    }
}