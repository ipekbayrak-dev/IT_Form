namespace IT_WFA_ADO
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
            components = new System.ComponentModel.Container();
            LbCustomers = new ListBox();
            LbOrders = new ListBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            detaylToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // LbCustomers
            // 
            LbCustomers.FormattingEnabled = true;
            LbCustomers.Location = new Point(12, 12);
            LbCustomers.Name = "LbCustomers";
            LbCustomers.Size = new Size(386, 424);
            LbCustomers.TabIndex = 0;
            LbCustomers.SelectedIndexChanged += LbCustomers_SelectedIndexChanged;
            // 
            // LbOrders
            // 
            LbOrders.ContextMenuStrip = contextMenuStrip1;
            LbOrders.FormattingEnabled = true;
            LbOrders.Location = new Point(404, 12);
            LbOrders.Name = "LbOrders";
            LbOrders.Size = new Size(384, 94);
            LbOrders.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { detaylToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(181, 48);
            // 
            // detaylToolStripMenuItem
            // 
            detaylToolStripMenuItem.Name = "detaylToolStripMenuItem";
            detaylToolStripMenuItem.Size = new Size(180, 22);
            detaylToolStripMenuItem.Text = "Detayları Göster";
            detaylToolStripMenuItem.Click += detaylToolStripMenuItem_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LbOrders);
            Controls.Add(LbCustomers);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListBox LbCustomers;
        private ListBox LbOrders;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem detaylToolStripMenuItem;
    }
}