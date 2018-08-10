namespace N2NPOS
{
    partial class frmMainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainScreen));
            this.tileSell = new MetroFramework.Controls.MetroTile();
            this.lbCurrentUser = new System.Windows.Forms.Label();
            this.tileTransactions = new MetroFramework.Controls.MetroTile();
            this.tileStock = new MetroFramework.Controls.MetroTile();
            this.tileRota = new MetroFramework.Controls.MetroTile();
            this.tileStaff = new MetroFramework.Controls.MetroTile();
            this.tileSettings = new MetroFramework.Controls.MetroTile();
            this.tileHelp = new MetroFramework.Controls.MetroTile();
            this.tileLogoff = new MetroFramework.Controls.MetroTile();
            this.tilesPanel = new System.Windows.Forms.Panel();
            this.tilesPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tileSell
            // 
            this.tileSell.ActiveControl = null;
            this.tileSell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(55)))), ((int)(((byte)(118)))));
            this.tileSell.DisplayFocusBorder = false;
            this.tileSell.ForeColor = System.Drawing.Color.White;
            this.tileSell.Location = new System.Drawing.Point(3, 3);
            this.tileSell.Name = "tileSell";
            this.tileSell.Size = new System.Drawing.Size(300, 150);
            this.tileSell.TabIndex = 0;
            this.tileSell.Text = "Sell";
            this.tileSell.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tileSell.TileImage = global::N2NPOS.Properties.Resources.pos;
            this.tileSell.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileSell.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileSell.UseCustomBackColor = true;
            this.tileSell.UseCustomForeColor = true;
            this.tileSell.UseSelectable = true;
            this.tileSell.UseStyleColors = true;
            this.tileSell.UseTileImage = true;
            this.tileSell.Click += new System.EventHandler(this.tileSell_Click);
            // 
            // lbCurrentUser
            // 
            this.lbCurrentUser.BackColor = System.Drawing.Color.Transparent;
            this.lbCurrentUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbCurrentUser.Font = new System.Drawing.Font("Vodafone", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurrentUser.ForeColor = System.Drawing.Color.White;
            this.lbCurrentUser.Location = new System.Drawing.Point(0, 0);
            this.lbCurrentUser.Name = "lbCurrentUser";
            this.lbCurrentUser.Size = new System.Drawing.Size(1024, 100);
            this.lbCurrentUser.TabIndex = 1;
            this.lbCurrentUser.Text = "Hi, <forename>!";
            this.lbCurrentUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tileTransactions
            // 
            this.tileTransactions.ActiveControl = null;
            this.tileTransactions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.tileTransactions.DisplayFocusBorder = false;
            this.tileTransactions.ForeColor = System.Drawing.Color.White;
            this.tileTransactions.Location = new System.Drawing.Point(309, 3);
            this.tileTransactions.Name = "tileTransactions";
            this.tileTransactions.Size = new System.Drawing.Size(300, 306);
            this.tileTransactions.TabIndex = 2;
            this.tileTransactions.Text = "Transactions";
            this.tileTransactions.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tileTransactions.TileImage = global::N2NPOS.Properties.Resources.cash;
            this.tileTransactions.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileTransactions.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileTransactions.UseCustomBackColor = true;
            this.tileTransactions.UseCustomForeColor = true;
            this.tileTransactions.UseSelectable = true;
            this.tileTransactions.UseStyleColors = true;
            this.tileTransactions.UseTileImage = true;
            // 
            // tileStock
            // 
            this.tileStock.ActiveControl = null;
            this.tileStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(97)))), ((int)(((byte)(65)))));
            this.tileStock.DisplayFocusBorder = false;
            this.tileStock.ForeColor = System.Drawing.Color.White;
            this.tileStock.Location = new System.Drawing.Point(3, 159);
            this.tileStock.Name = "tileStock";
            this.tileStock.Size = new System.Drawing.Size(300, 150);
            this.tileStock.TabIndex = 3;
            this.tileStock.Text = "Stock";
            this.tileStock.TileImage = global::N2NPOS.Properties.Resources.stock;
            this.tileStock.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileStock.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileStock.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileStock.UseCustomBackColor = true;
            this.tileStock.UseCustomForeColor = true;
            this.tileStock.UseSelectable = true;
            this.tileStock.UseStyleColors = true;
            this.tileStock.UseTileImage = true;
            // 
            // tileRota
            // 
            this.tileRota.ActiveControl = null;
            this.tileRota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(77)))), ((int)(((byte)(80)))));
            this.tileRota.DisplayFocusBorder = false;
            this.tileRota.ForeColor = System.Drawing.Color.White;
            this.tileRota.Location = new System.Drawing.Point(462, 315);
            this.tileRota.Name = "tileRota";
            this.tileRota.Size = new System.Drawing.Size(147, 150);
            this.tileRota.TabIndex = 4;
            this.tileRota.Text = "Rota";
            this.tileRota.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tileRota.TileImage = global::N2NPOS.Properties.Resources.rota;
            this.tileRota.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileRota.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileRota.UseCustomBackColor = true;
            this.tileRota.UseCustomForeColor = true;
            this.tileRota.UseSelectable = true;
            this.tileRota.UseStyleColors = true;
            this.tileRota.UseTileImage = true;
            // 
            // tileStaff
            // 
            this.tileStaff.ActiveControl = null;
            this.tileStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(132)))), ((int)(((byte)(121)))));
            this.tileStaff.DisplayFocusBorder = false;
            this.tileStaff.ForeColor = System.Drawing.Color.White;
            this.tileStaff.Location = new System.Drawing.Point(156, 315);
            this.tileStaff.Name = "tileStaff";
            this.tileStaff.Size = new System.Drawing.Size(147, 306);
            this.tileStaff.TabIndex = 5;
            this.tileStaff.Text = "Staff";
            this.tileStaff.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tileStaff.TileImage = ((System.Drawing.Image)(resources.GetObject("tileStaff.TileImage")));
            this.tileStaff.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileStaff.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileStaff.UseCustomBackColor = true;
            this.tileStaff.UseCustomForeColor = true;
            this.tileStaff.UseSelectable = true;
            this.tileStaff.UseStyleColors = true;
            this.tileStaff.UseTileImage = true;
            // 
            // tileSettings
            // 
            this.tileSettings.ActiveControl = null;
            this.tileSettings.BackColor = System.Drawing.Color.DarkOrange;
            this.tileSettings.DisplayFocusBorder = false;
            this.tileSettings.ForeColor = System.Drawing.Color.Black;
            this.tileSettings.Location = new System.Drawing.Point(309, 315);
            this.tileSettings.Name = "tileSettings";
            this.tileSettings.Size = new System.Drawing.Size(147, 150);
            this.tileSettings.TabIndex = 6;
            this.tileSettings.Text = "Settings";
            this.tileSettings.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tileSettings.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileSettings.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileSettings.UseCustomBackColor = true;
            this.tileSettings.UseCustomForeColor = true;
            this.tileSettings.UseSelectable = true;
            this.tileSettings.UseStyleColors = true;
            this.tileSettings.UseTileImage = true;
            // 
            // tileHelp
            // 
            this.tileHelp.ActiveControl = null;
            this.tileHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(105)))), ((int)(((byte)(165)))));
            this.tileHelp.DisplayFocusBorder = false;
            this.tileHelp.ForeColor = System.Drawing.Color.White;
            this.tileHelp.Location = new System.Drawing.Point(3, 315);
            this.tileHelp.Name = "tileHelp";
            this.tileHelp.Size = new System.Drawing.Size(147, 306);
            this.tileHelp.TabIndex = 7;
            this.tileHelp.Text = "Help";
            this.tileHelp.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tileHelp.TileImage = global::N2NPOS.Properties.Resources.help;
            this.tileHelp.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileHelp.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileHelp.UseCustomBackColor = true;
            this.tileHelp.UseCustomForeColor = true;
            this.tileHelp.UseSelectable = true;
            this.tileHelp.UseStyleColors = true;
            this.tileHelp.UseTileImage = true;
            // 
            // tileLogoff
            // 
            this.tileLogoff.ActiveControl = null;
            this.tileLogoff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(130)))), ((int)(((byte)(90)))));
            this.tileLogoff.DisplayFocusBorder = false;
            this.tileLogoff.ForeColor = System.Drawing.Color.White;
            this.tileLogoff.Location = new System.Drawing.Point(309, 471);
            this.tileLogoff.Name = "tileLogoff";
            this.tileLogoff.Size = new System.Drawing.Size(300, 150);
            this.tileLogoff.TabIndex = 8;
            this.tileLogoff.Text = "Log Off";
            this.tileLogoff.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tileLogoff.TileImage = global::N2NPOS.Properties.Resources.logoff;
            this.tileLogoff.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileLogoff.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileLogoff.UseCustomBackColor = true;
            this.tileLogoff.UseCustomForeColor = true;
            this.tileLogoff.UseSelectable = true;
            this.tileLogoff.UseStyleColors = true;
            this.tileLogoff.UseTileImage = true;
            // 
            // tilesPanel
            // 
            this.tilesPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tilesPanel.BackColor = System.Drawing.Color.Transparent;
            this.tilesPanel.Controls.Add(this.tileSell);
            this.tilesPanel.Controls.Add(this.tileLogoff);
            this.tilesPanel.Controls.Add(this.tileTransactions);
            this.tilesPanel.Controls.Add(this.tileHelp);
            this.tilesPanel.Controls.Add(this.tileStock);
            this.tilesPanel.Controls.Add(this.tileSettings);
            this.tilesPanel.Controls.Add(this.tileRota);
            this.tilesPanel.Controls.Add(this.tileStaff);
            this.tilesPanel.Location = new System.Drawing.Point(215, 103);
            this.tilesPanel.MaximumSize = new System.Drawing.Size(614, 620);
            this.tilesPanel.MinimumSize = new System.Drawing.Size(614, 620);
            this.tilesPanel.Name = "tilesPanel";
            this.tilesPanel.Size = new System.Drawing.Size(614, 620);
            this.tilesPanel.TabIndex = 9;
            // 
            // frmMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::N2NPOS.Properties.Resources.splash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.tilesPanel);
            this.Controls.Add(this.lbCurrentUser);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMainScreen";
            this.Text = "frmMainScreen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMainScreen_Load);
            this.tilesPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public MetroFramework.Controls.MetroTile tileSell;
        public System.Windows.Forms.Label lbCurrentUser;
        public MetroFramework.Controls.MetroTile tileTransactions;
        public MetroFramework.Controls.MetroTile tileStock;
        public MetroFramework.Controls.MetroTile tileRota;
        public MetroFramework.Controls.MetroTile tileStaff;
        public MetroFramework.Controls.MetroTile tileSettings;
        public MetroFramework.Controls.MetroTile tileHelp;
        public MetroFramework.Controls.MetroTile tileLogoff;
        private System.Windows.Forms.Panel tilesPanel;
    }
}