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
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pDataGV).BeginInit();
            updateGrpBox.SuspendLayout();
            SuspendLayout();
            // 
            // pDataGV
            // 
            pDataGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            pDataGV.Location = new Point(99, 12);
            pDataGV.Name = "pDataGV";
            pDataGV.RowTemplate.Height = 25;
            pDataGV.Size = new Size(571, 179);
            pDataGV.TabIndex = 0;
            pDataGV.CellContentClick += pDataGV_CellContentClick;
            // 
            // updateGrpBox
            // 
            updateGrpBox.Controls.Add(button1);
            updateGrpBox.Controls.Add(comboBox1);
            updateGrpBox.Controls.Add(label4);
            updateGrpBox.Controls.Add(label3);
            updateGrpBox.Controls.Add(textBox3);
            updateGrpBox.Controls.Add(textBox2);
            updateGrpBox.Controls.Add(label2);
            updateGrpBox.Controls.Add(textBox1);
            updateGrpBox.Controls.Add(label1);
            updateGrpBox.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            updateGrpBox.Location = new Point(99, 219);
            updateGrpBox.Name = "updateGrpBox";
            updateGrpBox.Size = new Size(577, 279);
            updateGrpBox.TabIndex = 1;
            updateGrpBox.TabStop = false;
            updateGrpBox.Text = "Let's Update The Product";
            updateGrpBox.Enter += groupBox1_Enter;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(234, 70);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(198, 29);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(98, 70);
            label1.Name = "label1";
            label1.Size = new Size(90, 37);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(98, 125);
            label2.Name = "label2";
            label2.Size = new Size(90, 37);
            label2.TabIndex = 2;
            label2.Text = "label2";
            label2.Click += label2_Click_1;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(234, 125);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(198, 29);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(234, 178);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(198, 29);
            textBox3.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(98, 170);
            label3.Name = "label3";
            label3.Size = new Size(90, 37);
            label3.TabIndex = 5;
            label3.Text = "label3";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(98, 218);
            label4.Name = "label4";
            label4.Size = new Size(90, 37);
            label4.TabIndex = 6;
            label4.Text = "label4";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(234, 226);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(198, 29);
            comboBox1.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(465, 226);
            button1.Name = "button1";
            button1.Size = new Size(106, 47);
            button1.TabIndex = 8;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // updateProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 535);
            Controls.Add(updateGrpBox);
            Controls.Add(pDataGV);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "updateProductForm";
            Text = "updateProductForm";
            Load += updateProductForm_Load;
            ((System.ComponentModel.ISupportInitialize)pDataGV).EndInit();
            updateGrpBox.ResumeLayout(false);
            updateGrpBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView pDataGV;
        private GroupBox updateGrpBox;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private ComboBox comboBox1;
        private Label label4;
        private Button button1;
    }
}