namespace N2NPOS
{
    partial class frmBugReporting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBugReporting));
            this.crashReportWizard = new DevComponents.DotNetBar.Wizard();
            this.wizardPage3 = new DevComponents.DotNetBar.WizardPage();
            this.lblExceptionTxt = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.wizardPage1 = new DevComponents.DotNetBar.WizardPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.wizardPage2 = new DevComponents.DotNetBar.WizardPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rtbStepsPrior = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.wizardPage4 = new DevComponents.DotNetBar.WizardPage();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.rtbCrashReportView = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.crashReportWizard.SuspendLayout();
            this.wizardPage3.SuspendLayout();
            this.wizardPage1.SuspendLayout();
            this.wizardPage2.SuspendLayout();
            this.wizardPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // crashReportWizard
            // 
            this.crashReportWizard.CancelButtonText = "Close";
            this.crashReportWizard.Cursor = System.Windows.Forms.Cursors.Default;
            this.crashReportWizard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crashReportWizard.FinishButtonTabIndex = 3;
            // 
            // 
            // 
            this.crashReportWizard.FooterStyle.BackColor = System.Drawing.SystemColors.Control;
            this.crashReportWizard.FooterStyle.BackColorGradientAngle = 90;
            this.crashReportWizard.FooterStyle.BorderBottomWidth = 1;
            this.crashReportWizard.FooterStyle.BorderColor = System.Drawing.SystemColors.Control;
            this.crashReportWizard.FooterStyle.BorderLeftWidth = 1;
            this.crashReportWizard.FooterStyle.BorderRightWidth = 1;
            this.crashReportWizard.FooterStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Etched;
            this.crashReportWizard.FooterStyle.BorderTopColor = System.Drawing.SystemColors.Control;
            this.crashReportWizard.FooterStyle.BorderTopWidth = 1;
            this.crashReportWizard.FooterStyle.Class = "";
            this.crashReportWizard.FooterStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.crashReportWizard.FooterStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.crashReportWizard.FooterStyle.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.crashReportWizard.HeaderCaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // 
            // 
            this.crashReportWizard.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.crashReportWizard.HeaderStyle.BackColorGradientAngle = 90;
            this.crashReportWizard.HeaderStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Etched;
            this.crashReportWizard.HeaderStyle.BorderBottomWidth = 1;
            this.crashReportWizard.HeaderStyle.BorderColor = System.Drawing.SystemColors.Control;
            this.crashReportWizard.HeaderStyle.BorderLeftWidth = 1;
            this.crashReportWizard.HeaderStyle.BorderRightWidth = 1;
            this.crashReportWizard.HeaderStyle.BorderTopWidth = 1;
            this.crashReportWizard.HeaderStyle.Class = "";
            this.crashReportWizard.HeaderStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.crashReportWizard.HeaderStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.crashReportWizard.HeaderStyle.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.crashReportWizard.HelpButtonVisible = false;
            this.crashReportWizard.Location = new System.Drawing.Point(0, 0);
            this.crashReportWizard.Name = "crashReportWizard";
            this.crashReportWizard.Size = new System.Drawing.Size(489, 636);
            this.crashReportWizard.TabIndex = 0;
            this.crashReportWizard.WizardPages.AddRange(new DevComponents.DotNetBar.WizardPage[] {
            this.wizardPage3,
            this.wizardPage1,
            this.wizardPage2,
            this.wizardPage4});
            // 
            // wizardPage3
            // 
            this.wizardPage3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wizardPage3.BackColor = System.Drawing.Color.White;
            this.wizardPage3.Controls.Add(this.lblExceptionTxt);
            this.wizardPage3.Controls.Add(this.label8);
            this.wizardPage3.Controls.Add(this.label3);
            this.wizardPage3.InteriorPage = false;
            this.wizardPage3.Location = new System.Drawing.Point(0, 0);
            this.wizardPage3.Name = "wizardPage3";
            this.wizardPage3.Size = new System.Drawing.Size(489, 590);
            // 
            // 
            // 
            this.wizardPage3.Style.BackColor = System.Drawing.Color.White;
            this.wizardPage3.Style.BackgroundImagePosition = DevComponents.DotNetBar.eStyleBackgroundImage.TopLeft;
            this.wizardPage3.Style.Class = "";
            this.wizardPage3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.wizardPage3.StyleMouseDown.Class = "";
            this.wizardPage3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.wizardPage3.StyleMouseOver.Class = "";
            this.wizardPage3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.wizardPage3.TabIndex = 9;
            // 
            // lblExceptionTxt
            // 
            this.lblExceptionTxt.AutoSize = true;
            this.lblExceptionTxt.Font = new System.Drawing.Font("Vodafone", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExceptionTxt.Location = new System.Drawing.Point(16, 450);
            this.lblExceptionTxt.Name = "lblExceptionTxt";
            this.lblExceptionTxt.Size = new System.Drawing.Size(197, 34);
            this.lblExceptionTxt.TabIndex = 2;
            this.lblExceptionTxt.Text = "Error given by N2NPOS:\r\n+ environment.newline + <bug>";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Vodafone", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(465, 244);
            this.label8.TabIndex = 1;
            this.label8.Text = resources.GetString("label8.Text");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Vodafone", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(433, 120);
            this.label3.TabIndex = 0;
            this.label3.Text = "We\'re sorry!\r\n\r\nAn unknown error has occured.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wizardPage1
            // 
            this.wizardPage1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wizardPage1.BackColor = System.Drawing.Color.White;
            this.wizardPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.wizardPage1.Controls.Add(this.label1);
            this.wizardPage1.Controls.Add(this.label2);
            this.wizardPage1.InteriorPage = false;
            this.wizardPage1.Location = new System.Drawing.Point(0, 0);
            this.wizardPage1.Name = "wizardPage1";
            this.wizardPage1.Size = new System.Drawing.Size(489, 590);
            // 
            // 
            // 
            this.wizardPage1.Style.BackColor = System.Drawing.Color.White;
            this.wizardPage1.Style.BackgroundImagePosition = DevComponents.DotNetBar.eStyleBackgroundImage.TopLeft;
            this.wizardPage1.Style.Class = "";
            this.wizardPage1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.wizardPage1.StyleMouseDown.Class = "";
            this.wizardPage1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.wizardPage1.StyleMouseOver.Class = "";
            this.wizardPage1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.wizardPage1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Vodafone", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 66);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to the Bug Reporting Wizard";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Vodafone", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(210, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 458);
            this.label2.TabIndex = 1;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // wizardPage2
            // 
            this.wizardPage2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wizardPage2.AntiAlias = false;
            this.wizardPage2.Controls.Add(this.textBox1);
            this.wizardPage2.Controls.Add(this.label4);
            this.wizardPage2.Controls.Add(this.rtbStepsPrior);
            this.wizardPage2.Controls.Add(this.label5);
            this.wizardPage2.Controls.Add(this.label6);
            this.wizardPage2.Controls.Add(this.label7);
            this.wizardPage2.InteriorPage = false;
            this.wizardPage2.Location = new System.Drawing.Point(0, 0);
            this.wizardPage2.Name = "wizardPage2";
            this.wizardPage2.Size = new System.Drawing.Size(489, 590);
            // 
            // 
            // 
            this.wizardPage2.Style.BackColor = System.Drawing.Color.White;
            this.wizardPage2.Style.Class = "";
            this.wizardPage2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.wizardPage2.StyleMouseDown.Class = "";
            this.wizardPage2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.wizardPage2.StyleMouseOver.Class = "";
            this.wizardPage2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.wizardPage2.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(15, 147);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(462, 22);
            this.textBox1.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Vodafone", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(275, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Explain, in a sentence, what happened.";
            // 
            // rtbStepsPrior
            // 
            this.rtbStepsPrior.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbStepsPrior.Location = new System.Drawing.Point(15, 242);
            this.rtbStepsPrior.Name = "rtbStepsPrior";
            this.rtbStepsPrior.Size = new System.Drawing.Size(462, 334);
            this.rtbStepsPrior.TabIndex = 10;
            this.rtbStepsPrior.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Vodafone", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(446, 51);
            this.label5.TabIndex = 9;
            this.label5.Text = "What steps did you take prior to the bug occuring?\r\nTry and be as detailed as you" +
    " can, as this helps us to fix the bug\r\nquicker, and reproduce the issue you\'re h" +
    "aving.";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Vodafone", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(465, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Please fill in the details below as accurately as possible:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Vodafone", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(465, 64);
            this.label7.TabIndex = 7;
            this.label7.Text = "We\'re sorry that you\'re having issues\r\nwith N2NPOS.";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wizardPage4
            // 
            this.wizardPage4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wizardPage4.AntiAlias = false;
            this.wizardPage4.Controls.Add(this.btnGenerateReport);
            this.wizardPage4.Controls.Add(this.rtbCrashReportView);
            this.wizardPage4.Controls.Add(this.label10);
            this.wizardPage4.Controls.Add(this.label11);
            this.wizardPage4.InteriorPage = false;
            this.wizardPage4.Location = new System.Drawing.Point(0, 0);
            this.wizardPage4.Name = "wizardPage4";
            this.wizardPage4.Size = new System.Drawing.Size(489, 590);
            // 
            // 
            // 
            this.wizardPage4.Style.BackColor = System.Drawing.Color.White;
            this.wizardPage4.Style.Class = "";
            this.wizardPage4.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.wizardPage4.StyleMouseDown.Class = "";
            this.wizardPage4.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.wizardPage4.StyleMouseOver.Class = "";
            this.wizardPage4.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.wizardPage4.TabIndex = 10;
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Font = new System.Drawing.Font("Vodafone", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateReport.Location = new System.Drawing.Point(15, 157);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(462, 30);
            this.btnGenerateReport.TabIndex = 15;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            // 
            // rtbCrashReportView
            // 
            this.rtbCrashReportView.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbCrashReportView.Location = new System.Drawing.Point(15, 203);
            this.rtbCrashReportView.Name = "rtbCrashReportView";
            this.rtbCrashReportView.Size = new System.Drawing.Size(462, 376);
            this.rtbCrashReportView.TabIndex = 14;
            this.rtbCrashReportView.Text = "";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Vodafone", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(465, 91);
            this.label10.TabIndex = 12;
            this.label10.Text = "Below is an exact copy of the report that will be sent to Earnshaw Software.\r\n\r\nY" +
    "ou can choose to remove any element of the report, if you wish.\r\n\r\nClick \'Genera" +
    "te Report\' to continue.";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Vodafone", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(145, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(190, 32);
            this.label11.TabIndex = 11;
            this.label11.Text = "Report Review";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmBugReporting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 636);
            this.Controls.Add(this.crashReportWizard);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBugReporting";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crash Report";
            this.Load += new System.EventHandler(this.frmBugReporting_Load);
            this.crashReportWizard.ResumeLayout(false);
            this.wizardPage3.ResumeLayout(false);
            this.wizardPage3.PerformLayout();
            this.wizardPage1.ResumeLayout(false);
            this.wizardPage2.ResumeLayout(false);
            this.wizardPage2.PerformLayout();
            this.wizardPage4.ResumeLayout(false);
            this.wizardPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Wizard crashReportWizard;
        private DevComponents.DotNetBar.WizardPage wizardPage1;
        private DevComponents.DotNetBar.WizardPage wizardPage2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtbStepsPrior;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private DevComponents.DotNetBar.WizardPage wizardPage3;
        private System.Windows.Forms.Label lblExceptionTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private DevComponents.DotNetBar.WizardPage wizardPage4;
        private System.Windows.Forms.RichTextBox rtbCrashReportView;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnGenerateReport;
    }
}