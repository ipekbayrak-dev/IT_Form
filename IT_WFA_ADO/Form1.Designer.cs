namespace IT_WFA_ADO
{
    partial class Form1
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
            BtnGetCategories = new Button();
            LbProducts = new ListBox();
            LbCategories = new ListBox();
            SuspendLayout();
            // 
            // BtnGetCategories
            // 
            BtnGetCategories.Location = new Point(12, 12);
            BtnGetCategories.Name = "BtnGetCategories";
            BtnGetCategories.Size = new Size(210, 89);
            BtnGetCategories.TabIndex = 0;
            BtnGetCategories.Text = "Kategorileri Getir";
            BtnGetCategories.UseVisualStyleBackColor = true;
            BtnGetCategories.Click += BtnGetCategories_Click;
            // 
            // LbProducts
            // 
            LbProducts.FormattingEnabled = true;
            LbProducts.Location = new Point(228, 17);
            LbProducts.Name = "LbProducts";
            LbProducts.Size = new Size(455, 439);
            LbProducts.TabIndex = 1;
            // 
            // LbCategories
            // 
            LbCategories.FormattingEnabled = true;
            LbCategories.Location = new Point(12, 107);
            LbCategories.Name = "LbCategories";
            LbCategories.Size = new Size(210, 349);
            LbCategories.TabIndex = 2;
            LbCategories.SelectedIndexChanged += LbCategories_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(695, 464);
            Controls.Add(LbCategories);
            Controls.Add(LbProducts);
            Controls.Add(BtnGetCategories);
            Name = "Form1";
            Text = "WFA_ADO";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnGetCategories;
        private ListBox LbProducts;
        private ListBox LbCategories;
    }
}
