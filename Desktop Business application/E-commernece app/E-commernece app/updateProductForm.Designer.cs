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
            ((System.ComponentModel.ISupportInitialize)pDataGV).BeginInit();
            SuspendLayout();
            // 
            // pDataGV
            // 
            pDataGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            pDataGV.Location = new Point(51, 41);
            pDataGV.Name = "pDataGV";
            pDataGV.RowTemplate.Height = 25;
            pDataGV.Size = new Size(643, 187);
            pDataGV.TabIndex = 0;
            pDataGV.CellContentClick += pDataGV_CellContentClick;
            // 
            // updateProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pDataGV);
            Name = "updateProductForm";
            Text = "updateProductForm";
            Load += updateProductForm_Load;
            ((System.ComponentModel.ISupportInitialize)pDataGV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView pDataGV;
    }
}