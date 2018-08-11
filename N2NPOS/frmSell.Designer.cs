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
            this.btnClearItems = new System.Windows.Forms.Button();
            this.btnCancelSale = new System.Windows.Forms.Button();
            this.btnCompleteSale = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.orderListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.stockListView = new System.Windows.Forms.ListView();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(55)))), ((int)(((byte)(118)))));
            this.panel1.Controls.Add(this.btnClearItems);
            this.panel1.Controls.Add(this.btnCancelSale);
            this.panel1.Controls.Add(this.btnCompleteSale);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblSubtotal);
            this.panel1.Controls.Add(this.orderListBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(774, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 768);
            this.panel1.TabIndex = 0;
            // 
            // btnClearItems
            // 
            this.btnClearItems.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnClearItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearItems.Font = new System.Drawing.Font("Vodafone", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearItems.ForeColor = System.Drawing.Color.White;
            this.btnClearItems.Location = new System.Drawing.Point(0, 546);
            this.btnClearItems.Name = "btnClearItems";
            this.btnClearItems.Size = new System.Drawing.Size(250, 74);
            this.btnClearItems.TabIndex = 6;
            this.btnClearItems.Text = "Clear Items";
            this.btnClearItems.UseVisualStyleBackColor = true;
            this.btnClearItems.Click += new System.EventHandler(this.btnClearItems_Click);
            // 
            // btnCancelSale
            // 
            this.btnCancelSale.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCancelSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelSale.Font = new System.Drawing.Font("Vodafone", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelSale.ForeColor = System.Drawing.Color.White;
            this.btnCancelSale.Location = new System.Drawing.Point(0, 620);
            this.btnCancelSale.Name = "btnCancelSale";
            this.btnCancelSale.Size = new System.Drawing.Size(250, 74);
            this.btnCancelSale.TabIndex = 5;
            this.btnCancelSale.Text = "Cancel Sale";
            this.btnCancelSale.UseVisualStyleBackColor = true;
            this.btnCancelSale.Click += new System.EventHandler(this.btnCancelSale_Click);
            // 
            // btnCompleteSale
            // 
            this.btnCompleteSale.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCompleteSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompleteSale.Font = new System.Drawing.Font("Vodafone", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompleteSale.ForeColor = System.Drawing.Color.White;
            this.btnCompleteSale.Location = new System.Drawing.Point(0, 694);
            this.btnCompleteSale.Name = "btnCompleteSale";
            this.btnCompleteSale.Size = new System.Drawing.Size(250, 74);
            this.btnCompleteSale.TabIndex = 4;
            this.btnCompleteSale.Text = "Complete Sale";
            this.btnCompleteSale.UseVisualStyleBackColor = true;
            this.btnCompleteSale.Click += new System.EventHandler(this.btnCompleteSale_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Vodafone", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(70, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Your Order:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Vodafone", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 419);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Subtotal:";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.Font = new System.Drawing.Font("Vodafone", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.ForeColor = System.Drawing.Color.White;
            this.lblSubtotal.Location = new System.Drawing.Point(100, 403);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(147, 56);
            this.lblSubtotal.TabIndex = 1;
            this.lblSubtotal.Text = "£0.00";
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // orderListBox
            // 
            this.orderListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(55)))), ((int)(((byte)(138)))));
            this.orderListBox.Font = new System.Drawing.Font("Vodafone", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderListBox.ForeColor = System.Drawing.Color.White;
            this.orderListBox.FormattingEnabled = true;
            this.orderListBox.ItemHeight = 21;
            this.orderListBox.Location = new System.Drawing.Point(4, 39);
            this.orderListBox.Name = "orderListBox";
            this.orderListBox.Size = new System.Drawing.Size(243, 361);
            this.orderListBox.TabIndex = 0;
            this.orderListBox.DoubleClick += new System.EventHandler(this.orderListBox_DoubleClick);
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
            // stockListView
            // 
            this.stockListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(55)))), ((int)(((byte)(138)))));
            this.stockListView.Font = new System.Drawing.Font("Vodafone", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockListView.ForeColor = System.Drawing.Color.White;
            this.stockListView.Location = new System.Drawing.Point(236, 172);
            this.stockListView.Name = "stockListView";
            this.stockListView.Size = new System.Drawing.Size(121, 97);
            this.stockListView.TabIndex = 3;
            this.stockListView.TileSize = new System.Drawing.Size(150, 150);
            this.stockListView.UseCompatibleStateImageBehavior = false;
            this.stockListView.View = System.Windows.Forms.View.Tile;
            this.stockListView.Visible = false;
            this.Click += new System.EventHandler(this.stockListView_Click);
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
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox orderListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Button btnClearItems;
        private System.Windows.Forms.Button btnCancelSale;
        private System.Windows.Forms.Button btnCompleteSale;
        private System.Windows.Forms.ListView stockListView;
    }
}