namespace E_commernece_app
{
    partial class isValidCrendentialsForUsers
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
            lblUserName = new Label();
            txtUserName = new TextBox();
            label2 = new Label();
            txtUserPassword = new TextBox();
            txtUpdatedPQuantty = new Label();
            cbxUserRole = new ComboBox();
            button1 = new Button();
            updateGrpBox = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            updateGrpBox.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.back_button;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(85, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(54, 103);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(148, 37);
            lblUserName.TabIndex = 0;
            lblUserName.Text = "User Name";
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserName.Location = new Point(243, 113);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(247, 29);
            txtUserName.TabIndex = 1;
            txtUserName.TextChanged += txtUserName_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 151);
            label2.Name = "label2";
            label2.Size = new Size(188, 37);
            label2.TabIndex = 2;
            label2.Text = "User Password";
            // 
            // txtUserPassword
            // 
            txtUserPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserPassword.Location = new Point(243, 159);
            txtUserPassword.Name = "txtUserPassword";
            txtUserPassword.Size = new Size(247, 29);
            txtUserPassword.TabIndex = 3;
            // 
            // txtUpdatedPQuantty
            // 
            txtUpdatedPQuantty.AutoSize = true;
            txtUpdatedPQuantty.Location = new Point(54, 205);
            txtUpdatedPQuantty.Name = "txtUpdatedPQuantty";
            txtUpdatedPQuantty.Size = new Size(129, 37);
            txtUpdatedPQuantty.TabIndex = 5;
            txtUpdatedPQuantty.Text = "User Role";
            // 
            // cbxUserRole
            // 
            cbxUserRole.AllowDrop = true;
            cbxUserRole.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbxUserRole.FormattingEnabled = true;
            cbxUserRole.Location = new Point(243, 213);
            cbxUserRole.Name = "cbxUserRole";
            cbxUserRole.Size = new Size(247, 29);
            cbxUserRole.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(15, 288);
            button1.Name = "button1";
            button1.Size = new Size(546, 43);
            button1.TabIndex = 8;
            button1.Text = "Verify";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // updateGrpBox
            // 
            updateGrpBox.Controls.Add(button1);
            updateGrpBox.Controls.Add(cbxUserRole);
            updateGrpBox.Controls.Add(txtUpdatedPQuantty);
            updateGrpBox.Controls.Add(txtUserPassword);
            updateGrpBox.Controls.Add(label2);
            updateGrpBox.Controls.Add(txtUserName);
            updateGrpBox.Controls.Add(lblUserName);
            updateGrpBox.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            updateGrpBox.Location = new Point(118, 59);
            updateGrpBox.Name = "updateGrpBox";
            updateGrpBox.Size = new Size(587, 351);
            updateGrpBox.TabIndex = 2;
            updateGrpBox.TabStop = false;
            updateGrpBox.Text = "Let's verify you're the correct user";
            updateGrpBox.Enter += updateGrpBox_Enter;
            // 
            // isValidCrendentialsForUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(updateGrpBox);
            Controls.Add(pictureBox1);
            Name = "isValidCrendentialsForUsers";
            Text = "isValidCrendentialsForUsers";
            Load += isValidCrendentialsForUsers_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            updateGrpBox.ResumeLayout(false);
            updateGrpBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblUserName;
        private TextBox txtUserName;
        private Label label2;
        private TextBox txtUserPassword;
        private Label txtUpdatedPQuantty;
        private ComboBox cbxUserRole;
        private Button button1;
        private GroupBox updateGrpBox;
    }
}