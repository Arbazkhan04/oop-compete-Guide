namespace E_commernece_app
{
    partial class Form2
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            roleCombox = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(365, 362);
            button1.Name = "button1";
            button1.Size = new Size(137, 39);
            button1.TabIndex = 0;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLight;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(267, 29);
            label1.Name = "label1";
            label1.Size = new Size(339, 37);
            label1.TabIndex = 1;
            label1.Text = "E-commerencd Application";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(356, 89);
            label2.Name = "label2";
            label2.Size = new Size(130, 37);
            label2.TabIndex = 2;
            label2.Text = "Let's Ride";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(63, 52);
            label3.Name = "label3";
            label3.Size = new Size(88, 37);
            label3.TabIndex = 3;
            label3.Text = "Name";
            label3.Click += label3_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLight;
            groupBox1.Controls.Add(roleCombox);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Segoe UI", 20F, FontStyle.Underline, GraphicsUnit.Point);
            groupBox1.Location = new Point(136, 152);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(590, 204);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "SingUp Details";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // roleCombox
            // 
            roleCombox.BackColor = SystemColors.InactiveBorder;
            roleCombox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            roleCombox.FormattingEnabled = true;
            roleCombox.Location = new Point(233, 160);
            roleCombox.Name = "roleCombox";
            roleCombox.Size = new Size(226, 25);
            roleCombox.TabIndex = 8;
            roleCombox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(63, 160);
            label5.Name = "label5";
            label5.Size = new Size(69, 37);
            label5.TabIndex = 7;
            label5.Text = "Role";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(63, 101);
            label4.Name = "label4";
            label4.Size = new Size(128, 37);
            label4.TabIndex = 6;
            label4.Text = "Password";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.InactiveBorder;
            textBox2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(233, 113);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(226, 25);
            textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.InactiveBorder;
            textBox1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(233, 65);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(226, 25);
            textBox1.TabIndex = 4;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(864, 473);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Form2";
            Text = "Form2";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private Label label5;
        private Label label4;
        private TextBox textBox2;
        private ComboBox roleCombox;
    }
}