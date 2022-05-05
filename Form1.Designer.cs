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
            this.strpBtnExport = new System.Windows.Forms.ToolStripButton();
            this.strpBtnImport = new System.Windows.Forms.ToolStripDropDownButton();
            this.boxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTweets = new System.Windows.Forms.Label();
            this.btmStrp.SuspendLayout();
            this.topStrp.SuspendLayout();
            this.SuspendLayout();
            // 
            // btmStrp
            // 
            this.btmStrp.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.btmStrp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblAutosaveStatus,
            this.lblChars});
            this.btmStrp.Location = new System.Drawing.Point(0, 973);
            this.btmStrp.Name = "btmStrp";
            this.btmStrp.Size = new System.Drawing.Size(772, 39);
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
            this.topStrp.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.topStrp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.strpBtnAddTweet,
            this.strpBtnExport,
            this.strpBtnImport});
            this.topStrp.Location = new System.Drawing.Point(0, 0);
            this.topStrp.Name = "topStrp";
            this.topStrp.Size = new System.Drawing.Size(772, 40);
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
            // strpBtnExport
            // 
            this.strpBtnExport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.strpBtnExport.Image = ((System.Drawing.Image)(resources.GetObject("strpBtnExport.Image")));
            this.strpBtnExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.strpBtnExport.Name = "strpBtnExport";
            this.strpBtnExport.Size = new System.Drawing.Size(76, 34);
            this.strpBtnExport.Text = "Export";
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
            // boxName
            // 
            this.boxName.Location = new System.Drawing.Point(12, 73);
            this.boxName.Name = "boxName";
            this.boxName.Size = new System.Drawing.Size(748, 35);
            this.boxName.TabIndex = 2;
            this.boxName.TextChanged += new System.EventHandler(this.boxName_TextChanged);
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
            this.lblTweets.Location = new System.Drawing.Point(12, 111);
            this.lblTweets.Name = "lblTweets";
            this.lblTweets.Size = new System.Drawing.Size(81, 30);
            this.lblTweets.TabIndex = 5;
            this.lblTweets.Text = "Tweets:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(772, 1012);
            this.Controls.Add(this.lblTweets);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.boxName);
            this.Controls.Add(this.topStrp);
            this.Controls.Add(this.btmStrp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Hummingbird - A Twitter writing app";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.btmStrp.ResumeLayout(false);
            this.btmStrp.PerformLayout();
            this.topStrp.ResumeLayout(false);
            this.topStrp.PerformLayout();
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
    }
}
