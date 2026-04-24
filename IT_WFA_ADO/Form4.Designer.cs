namespace IT_WFA_ADO
{
    partial class Form4
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
            components = new System.ComponentModel.Container();
            DgvShippers = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            TsmiUpdate = new ToolStripMenuItem();
            TsmiDelete = new ToolStripMenuItem();
            LblId = new Label();
            BtnEkle = new Button();
            TbId = new TextBox();
            TbCompanyName = new TextBox();
            LblCompanyName = new Label();
            LblPhone = new Label();
            MtbPhone = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)DgvShippers).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // DgvShippers
            // 
            DgvShippers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvShippers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvShippers.ContextMenuStrip = contextMenuStrip1;
            DgvShippers.Dock = DockStyle.Top;
            DgvShippers.Location = new Point(0, 0);
            DgvShippers.MultiSelect = false;
            DgvShippers.Name = "DgvShippers";
            DgvShippers.ReadOnly = true;
            DgvShippers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvShippers.Size = new Size(800, 217);
            DgvShippers.TabIndex = 0;
            DgvShippers.CellClick += DgvShippers_CellClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { TsmiUpdate, TsmiDelete });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(121, 48);
            // 
            // TsmiUpdate
            // 
            TsmiUpdate.Name = "TsmiUpdate";
            TsmiUpdate.Size = new Size(120, 22);
            TsmiUpdate.Text = "Güncelle";
            TsmiUpdate.Click += TsmiUpdate_Click;
            // 
            // TsmiDelete
            // 
            TsmiDelete.Name = "TsmiDelete";
            TsmiDelete.Size = new Size(120, 22);
            TsmiDelete.Text = "Sil";
            TsmiDelete.Click += TsmiDelete_Click;
            // 
            // LblId
            // 
            LblId.AutoSize = true;
            LblId.Location = new Point(3, 224);
            LblId.Name = "LblId";
            LblId.Size = new Size(20, 15);
            LblId.TabIndex = 1;
            LblId.Text = "Id:";
            // 
            // BtnEkle
            // 
            BtnEkle.Location = new Point(318, 242);
            BtnEkle.Name = "BtnEkle";
            BtnEkle.Size = new Size(100, 23);
            BtnEkle.TabIndex = 3;
            BtnEkle.Text = "Ekle";
            BtnEkle.UseVisualStyleBackColor = true;
            BtnEkle.Click += BtnEkle_Click;
            // 
            // TbId
            // 
            TbId.Enabled = false;
            TbId.Location = new Point(0, 242);
            TbId.Name = "TbId";
            TbId.Size = new Size(100, 23);
            TbId.TabIndex = 2;
            // 
            // TbCompanyName
            // 
            TbCompanyName.Location = new Point(106, 242);
            TbCompanyName.Name = "TbCompanyName";
            TbCompanyName.Size = new Size(100, 23);
            TbCompanyName.TabIndex = 5;
            // 
            // LblCompanyName
            // 
            LblCompanyName.AutoSize = true;
            LblCompanyName.Location = new Point(103, 224);
            LblCompanyName.Name = "LblCompanyName";
            LblCompanyName.Size = new Size(97, 15);
            LblCompanyName.TabIndex = 6;
            LblCompanyName.Text = "Company Name:";
            // 
            // LblPhone
            // 
            LblPhone.AutoSize = true;
            LblPhone.Location = new Point(212, 224);
            LblPhone.Name = "LblPhone";
            LblPhone.Size = new Size(44, 15);
            LblPhone.TabIndex = 7;
            LblPhone.Text = "Phone:";
            // 
            // MtbPhone
            // 
            MtbPhone.Location = new Point(212, 242);
            MtbPhone.Mask = "(999) 000-0000";
            MtbPhone.Name = "MtbPhone";
            MtbPhone.Size = new Size(100, 23);
            MtbPhone.TabIndex = 8;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MtbPhone);
            Controls.Add(LblPhone);
            Controls.Add(LblCompanyName);
            Controls.Add(TbCompanyName);
            Controls.Add(BtnEkle);
            Controls.Add(TbId);
            Controls.Add(LblId);
            Controls.Add(DgvShippers);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)DgvShippers).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DgvShippers;
        private Label LblId;
        private Button BtnEkle;
        private TextBox TbId;
        private TextBox TbCompanyName;
        private Label LblCompanyName;
        private Label LblPhone;
        private MaskedTextBox MtbPhone;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem TsmiUpdate;
        private ToolStripMenuItem TsmiDelete;
    }
}