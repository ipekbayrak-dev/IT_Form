namespace IT_WFA_ADO
{
    partial class Form3
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
            DgvOrderDetail = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DgvOrderDetail).BeginInit();
            SuspendLayout();
            // 
            // DgvOrderDetail
            // 
            DgvOrderDetail.AllowUserToAddRows = false;
            DgvOrderDetail.AllowUserToDeleteRows = false;
            DgvOrderDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvOrderDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvOrderDetail.Dock = DockStyle.Fill;
            DgvOrderDetail.Location = new Point(0, 0);
            DgvOrderDetail.Name = "DgvOrderDetail";
            DgvOrderDetail.ReadOnly = true;
            DgvOrderDetail.Size = new Size(800, 450);
            DgvOrderDetail.TabIndex = 0;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DgvOrderDetail);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)DgvOrderDetail).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DgvOrderDetail;
    }
}