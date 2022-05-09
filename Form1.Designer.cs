namespace Hummingbird
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btmStrp = new System.Windows.Forms.StatusStrip();
            this.lblAutosaveStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblChars = new System.Windows.Forms.ToolStripStatusLabel();
            this.topStrp = new System.Windows.Forms.ToolStrip();
            this.strpBtnAddTweet = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.strpBtnRemove = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.strpBtnExport = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.strpBtnImport = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.boxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTweets = new System.Windows.Forms.Label();
            this.pnlTwtBoxes = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btmStrp.SuspendLayout();
            this.topStrp.SuspendLayout();
            this.pnlTwtBoxes.SuspendLayout();
            this.SuspendLayout();
            // 
            // btmStrp
            // 
            this.btmStrp.BackColor = System.Drawing.Color.Black;
            this.btmStrp.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.btmStrp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblAutosaveStatus,
            this.lblChars});
            this.btmStrp.Location = new System.Drawing.Point(0, 973);
            this.btmStrp.Name = "btmStrp";
            this.btmStrp.Size = new System.Drawing.Size(797, 39);
            this.btmStrp.TabIndex = 0;
            this.btmStrp.Text = "BtmStrp";
            // 
            // lblAutosaveStatus
            // 
            this.lblAutosaveStatus.Name = "lblAutosaveStatus";
            this.lblAutosaveStatus.Size = new System.Drawing.Size(109, 30);
            this.lblAutosaveStatus.Text = "Not Saved";
            // 
            // lblChars
            // 
            this.lblChars.Name = "lblChars";
            this.lblChars.Size = new System.Drawing.Size(173, 30);
            this.lblChars.Text = "Characters: x/280";
            // 
            // topStrp
            // 
            this.topStrp.BackColor = System.Drawing.SystemColors.Desktop;
            this.topStrp.Dock = System.Windows.Forms.DockStyle.None;
            this.topStrp.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.topStrp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.strpBtnAddTweet,
            this.toolStripSeparator4,
            this.strpBtnRemove,
            this.toolStripSeparator1,
            this.strpBtnExport,
            this.toolStripSeparator2,
            this.strpBtnImport,
            this.toolStripSeparator3});
            this.topStrp.Location = new System.Drawing.Point(0, 0);
            this.topStrp.Name = "topStrp";
            this.topStrp.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.topStrp.Size = new System.Drawing.Size(483, 40);
            this.topStrp.TabIndex = 1;
            this.topStrp.Text = "AddTwt/Export";
            // 
            // strpBtnAddTweet
            // 
            this.strpBtnAddTweet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.strpBtnAddTweet.Image = ((System.Drawing.Image)(resources.GetObject("strpBtnAddTweet.Image")));
            this.strpBtnAddTweet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.strpBtnAddTweet.Name = "strpBtnAddTweet";
            this.strpBtnAddTweet.Size = new System.Drawing.Size(115, 34);
            this.strpBtnAddTweet.Text = "Add Tweet";
            this.strpBtnAddTweet.Click += new System.EventHandler(this.strpBtnAddTweet_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 40);
            // 
            // strpBtnRemove
            // 
            this.strpBtnRemove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.strpBtnRemove.Image = ((System.Drawing.Image)(resources.GetObject("strpBtnRemove.Image")));
            this.strpBtnRemove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.strpBtnRemove.Name = "strpBtnRemove";
            this.strpBtnRemove.Size = new System.Drawing.Size(151, 34);
            this.strpBtnRemove.Text = "Remove Tweet";
            this.strpBtnRemove.Click += new System.EventHandler(this.strpBtnRemove_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 40);
            // 
            // strpBtnExport
            // 
            this.strpBtnExport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.strpBtnExport.Image = ((System.Drawing.Image)(resources.GetObject("strpBtnExport.Image")));
            this.strpBtnExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.strpBtnExport.Name = "strpBtnExport";
            this.strpBtnExport.Size = new System.Drawing.Size(76, 34);
            this.strpBtnExport.Text = "Export";
            this.strpBtnExport.Click += new System.EventHandler(this.strpBtnExport_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 40);
            // 
            // strpBtnImport
            // 
            this.strpBtnImport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.strpBtnImport.Image = ((System.Drawing.Image)(resources.GetObject("strpBtnImport.Image")));
            this.strpBtnImport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.strpBtnImport.Name = "strpBtnImport";
            this.strpBtnImport.Size = new System.Drawing.Size(96, 34);
            this.strpBtnImport.Text = "Import";
            this.strpBtnImport.DropDownClosed += new System.EventHandler(this.strpBtnImport_DropDownClosed);
            this.strpBtnImport.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.strpBtnImport_DropDownItemClicked);
            this.strpBtnImport.Click += new System.EventHandler(this.strpBtnImport_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 40);
            // 
            // boxName
            // 
            this.boxName.Location = new System.Drawing.Point(12, 73);
            this.boxName.Name = "boxName";
            this.boxName.Size = new System.Drawing.Size(773, 35);
            this.boxName.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 40);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(144, 30);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Thread Name:";
            // 
            // lblTweets
            // 
            this.lblTweets.AutoSize = true;
            this.lblTweets.Location = new System.Drawing.Point(3, 0);
            this.lblTweets.Name = "lblTweets";
            this.lblTweets.Size = new System.Drawing.Size(81, 30);
            this.lblTweets.TabIndex = 5;
            this.lblTweets.Text = "Tweets:";
            // 
            // pnlTwtBoxes
            // 
            this.pnlTwtBoxes.AutoScroll = true;
            this.pnlTwtBoxes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(71)))));
            this.pnlTwtBoxes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlTwtBoxes.Controls.Add(this.lblTweets);
            this.pnlTwtBoxes.Location = new System.Drawing.Point(12, 114);
            this.pnlTwtBoxes.Name = "pnlTwtBoxes";
            this.pnlTwtBoxes.Size = new System.Drawing.Size(773, 856);
            this.pnlTwtBoxes.TabIndex = 6;
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.Location = new System.Drawing.Point(707, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(78, 40);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Black;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(797, 1012);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pnlTwtBoxes);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.boxName);
            this.Controls.Add(this.topStrp);
            this.Controls.Add(this.btmStrp);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Opacity = 0.85D;
            this.Text = "Hummingbird - A Twitter writing app";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseDown);
            this.btmStrp.ResumeLayout(false);
            this.btmStrp.PerformLayout();
            this.topStrp.ResumeLayout(false);
            this.topStrp.PerformLayout();
            this.pnlTwtBoxes.ResumeLayout(false);
            this.pnlTwtBoxes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip btmStrp;
        private System.Windows.Forms.ToolStripStatusLabel lblAutosaveStatus;
        private System.Windows.Forms.ToolStripStatusLabel lblChars;
        private System.Windows.Forms.ToolStrip topStrp;
        private System.Windows.Forms.ToolStripButton strpBtnAddTweet;
        private System.Windows.Forms.ToolStripButton strpBtnExport;
        private System.Windows.Forms.TextBox boxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTweets;
        private System.Windows.Forms.ToolStripDropDownButton strpBtnImport;
        private System.Windows.Forms.ToolStripButton strpBtnRemove;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Panel pnlTwtBoxes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Button btnClose;
    }
}
