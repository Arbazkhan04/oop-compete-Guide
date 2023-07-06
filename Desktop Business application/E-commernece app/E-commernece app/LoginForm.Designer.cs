namespace E_commernece_app
{
    partial class LoginForm
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
            button1 = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            button3 = new Button();
            button2 = new Button();
            txtRole = new ComboBox();
            label5 = new Label();
            txtUserPassword = new TextBox();
            label4 = new Label();
            txtUserName = new TextBox();
            label3 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(737, 720);
            button1.Margin = new Padding(6, 7, 6, 7);
            button1.Name = "button1";
            button1.Size = new Size(161, 57);
            button1.TabIndex = 0;
            button1.Text = "next poag";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(313, 35);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(345, 37);
            label1.TabIndex = 1;
            label1.Text = "E-commeremce Application";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(378, 92);
            label2.Name = "label2";
            label2.Size = new Size(200, 37);
            label2.TabIndex = 2;
            label2.Text = "Let's Login First";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(txtRole);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtUserPassword);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtUserName);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(243, 153);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(525, 285);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "User Details";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(260, 218);
            button3.Name = "button3";
            button3.Size = new Size(75, 29);
            button3.TabIndex = 7;
            button3.Text = "Register";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(175, 218);
            button2.Name = "button2";
            button2.Size = new Size(75, 29);
            button2.TabIndex = 6;
            button2.Text = "Submit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtRole
            // 
            txtRole.BackColor = SystemColors.InactiveBorder;
            txtRole.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtRole.FormattingEnabled = true;
            txtRole.Location = new Point(175, 161);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(207, 25);
            txtRole.TabIndex = 5;
            txtRole.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(6, 149);
            label5.Name = "label5";
            label5.Size = new Size(146, 37);
            label5.TabIndex = 4;
            label5.Text = "Select Role";
            label5.Click += label5_Click;
            // 
            // txtUserPassword
            // 
            txtUserPassword.BackColor = SystemColors.InactiveBorder;
            txtUserPassword.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserPassword.Location = new Point(175, 114);
            txtUserPassword.Name = "txtUserPassword";
            txtUserPassword.Size = new Size(207, 25);
            txtUserPassword.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 101);
            label4.Name = "label4";
            label4.Size = new Size(128, 37);
            label4.TabIndex = 2;
            label4.Text = "Password";
            label4.Click += label4_Click;
            // 
            // txtUserName
            // 
            txtUserName.BackColor = SystemColors.InactiveBorder;
            txtUserName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserName.Location = new Point(175, 64);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(207, 25);
            txtUserName.TabIndex = 1;
            txtUserName.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 52);
            label3.Name = "label3";
            label3.Size = new Size(88, 37);
            label3.TabIndex = 0;
            label3.Text = "Name";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(810, 445);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6, 7, 6, 7);
            Name = "Form1";
            Text = "Login";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private TextBox txtUserName;
        private Label label3;
        private Label label4;
        private TextBox txtUserPassword;
        private Label label5;
        private ComboBox txtRole;
        private Button button2;
        private Button button3;
    }
}