namespace N2NPOS
{
    partial class frmSell
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.orderListBox = new System.Windows.Forms.ListBox();
            this.stockListView = new MetroFramework.Controls.MetroListView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(55)))), ((int)(((byte)(118)))));
            this.panel1.Controls.Add(this.orderListBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(774, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 768);
            this.panel1.TabIndex = 0;
            // 
            // orderListBox
            // 
            this.orderListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(55)))), ((int)(((byte)(138)))));
            this.orderListBox.Font = new System.Drawing.Font("Vodafone", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderListBox.ForeColor = System.Drawing.Color.White;
            this.orderListBox.FormattingEnabled = true;
            this.orderListBox.ItemHeight = 17;
            this.orderListBox.Location = new System.Drawing.Point(4, 39);
            this.orderListBox.Name = "orderListBox";
            this.orderListBox.Size = new System.Drawing.Size(120, 89);
            this.orderListBox.TabIndex = 0;
            // 
            // stockListView
            // 
            this.stockListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(55)))), ((int)(((byte)(138)))));
            this.stockListView.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.stockListView.ForeColor = System.Drawing.Color.White;
            this.stockListView.FullRowSelect = true;
            this.stockListView.Location = new System.Drawing.Point(279, 566);
            this.stockListView.Name = "stockListView";
            this.stockListView.OwnerDraw = true;
            this.stockListView.Size = new System.Drawing.Size(121, 97);
            this.stockListView.TabIndex = 1;
            this.stockListView.TileSize = new System.Drawing.Size(150, 150);
            this.stockListView.UseCompatibleStateImageBehavior = false;
            this.stockListView.UseSelectable = true;
            this.stockListView.View = System.Windows.Forms.View.Tile;
            this.stockListView.Visible = false;
            this.stockListView.Click += new System.EventHandler(this.stockListView_Click);
            this.stockListView.DoubleClick += new System.EventHandler(this.stockListView_DoubleClick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Vodafone", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(156, 317);
            this.label1.MaximumSize = new System.Drawing.Size(472, 96);
            this.label1.MinimumSize = new System.Drawing.Size(472, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 96);
            this.label1.TabIndex = 2;
            this.label1.Text = "No items in your stock!\r\n\r\nPlease add some items to your stock.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(55)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.stockListView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSell";
            this.Text = "frmSell";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSell_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroListView stockListView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox orderListBox;
    }
}