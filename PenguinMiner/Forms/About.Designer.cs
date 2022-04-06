namespace PenguinMiner.Forms
{
	partial class About
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
			this.pictureBox_icon = new System.Windows.Forms.PictureBox();
			this.label_title = new System.Windows.Forms.Label();
			this.label_by = new System.Windows.Forms.Label();
			this.link_milkenm = new System.Windows.Forms.LinkLabel();
			this.link_github = new System.Windows.Forms.LinkLabel();
			this.label_at = new System.Windows.Forms.Label();
			this.label_version = new System.Windows.Forms.Label();
			this.label_info = new System.Windows.Forms.Label();
			this.link_cpWiki = new System.Windows.Forms.LinkLabel();
			this.link_so1 = new System.Windows.Forms.LinkLabel();
			this.link_so2 = new System.Windows.Forms.LinkLabel();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_icon)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox_icon
			// 
			this.pictureBox_icon.Image = global::PenguinMiner.Properties.Resources.Helmet_PNG;
			this.pictureBox_icon.Location = new System.Drawing.Point(98, 12);
			this.pictureBox_icon.Name = "pictureBox_icon";
			this.pictureBox_icon.Size = new System.Drawing.Size(150, 150);
			this.pictureBox_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox_icon.TabIndex = 0;
			this.pictureBox_icon.TabStop = false;
			// 
			// label_title
			// 
			this.label_title.AutoSize = true;
			this.label_title.Font = new System.Drawing.Font("Bumbastika", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_title.Location = new System.Drawing.Point(104, 145);
			this.label_title.Name = "label_title";
			this.label_title.Size = new System.Drawing.Size(139, 50);
			this.label_title.TabIndex = 1;
			this.label_title.Text = "Penguin\r\nMiner";
			this.label_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label_by
			// 
			this.label_by.AutoSize = true;
			this.label_by.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_by.Location = new System.Drawing.Point(31, 221);
			this.label_by.Name = "label_by";
			this.label_by.Size = new System.Drawing.Size(29, 19);
			this.label_by.TabIndex = 2;
			this.label_by.Text = "By:";
			// 
			// link_milkenm
			// 
			this.link_milkenm.ActiveLinkColor = System.Drawing.SystemColors.ControlText;
			this.link_milkenm.AutoSize = true;
			this.link_milkenm.DisabledLinkColor = System.Drawing.SystemColors.ControlText;
			this.link_milkenm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.link_milkenm.ForeColor = System.Drawing.SystemColors.ControlText;
			this.link_milkenm.LinkColor = System.Drawing.SystemColors.ControlText;
			this.link_milkenm.Location = new System.Drawing.Point(66, 221);
			this.link_milkenm.Name = "link_milkenm";
			this.link_milkenm.Size = new System.Drawing.Size(64, 19);
			this.link_milkenm.TabIndex = 4;
			this.link_milkenm.TabStop = true;
			this.link_milkenm.Text = "Milkenm";
			this.link_milkenm.VisitedLinkColor = System.Drawing.SystemColors.ControlText;
			this.link_milkenm.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_milkenm_LinkClicked);
			// 
			// link_github
			// 
			this.link_github.ActiveLinkColor = System.Drawing.SystemColors.ControlText;
			this.link_github.AutoSize = true;
			this.link_github.DisabledLinkColor = System.Drawing.SystemColors.ControlText;
			this.link_github.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.link_github.ForeColor = System.Drawing.SystemColors.ControlText;
			this.link_github.LinkColor = System.Drawing.SystemColors.ControlText;
			this.link_github.Location = new System.Drawing.Point(165, 221);
			this.link_github.Name = "link_github";
			this.link_github.Size = new System.Drawing.Size(150, 19);
			this.link_github.TabIndex = 5;
			this.link_github.TabStop = true;
			this.link_github.Text = "GitHub/PenguinMiner";
			this.link_github.VisitedLinkColor = System.Drawing.SystemColors.ControlText;
			this.link_github.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_github_LinkClicked);
			// 
			// label_at
			// 
			this.label_at.AutoSize = true;
			this.label_at.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_at.Location = new System.Drawing.Point(136, 221);
			this.label_at.Name = "label_at";
			this.label_at.Size = new System.Drawing.Size(23, 19);
			this.label_at.TabIndex = 3;
			this.label_at.Text = "@";
			// 
			// label_version
			// 
			this.label_version.AutoSize = true;
			this.label_version.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_version.Location = new System.Drawing.Point(221, 174);
			this.label_version.Name = "label_version";
			this.label_version.Size = new System.Drawing.Size(36, 19);
			this.label_version.TabIndex = 6;
			this.label_version.Text = "v1.0";
			// 
			// label_info
			// 
			this.label_info.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_info.Location = new System.Drawing.Point(22, 247);
			this.label_info.Name = "label_info";
			this.label_info.Size = new System.Drawing.Size(302, 69);
			this.label_info.TabIndex = 7;
			this.label_info.Text = "Some resources were taken from the Club Penguin Rewritten Wiki and some code was " +
    "taken from StackOverflow.";
			this.label_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// link_cpWiki
			// 
			this.link_cpWiki.ActiveLinkColor = System.Drawing.SystemColors.ControlText;
			this.link_cpWiki.AutoSize = true;
			this.link_cpWiki.DisabledLinkColor = System.Drawing.SystemColors.ControlText;
			this.link_cpWiki.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.link_cpWiki.LinkColor = System.Drawing.SystemColors.ControlText;
			this.link_cpWiki.Location = new System.Drawing.Point(39, 325);
			this.link_cpWiki.Name = "link_cpWiki";
			this.link_cpWiki.Size = new System.Drawing.Size(59, 19);
			this.link_cpWiki.TabIndex = 8;
			this.link_cpWiki.TabStop = true;
			this.link_cpWiki.Text = "CP Wiki";
			this.link_cpWiki.VisitedLinkColor = System.Drawing.SystemColors.ControlText;
			this.link_cpWiki.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_cpWiki_LinkClicked);
			// 
			// link_so1
			// 
			this.link_so1.ActiveLinkColor = System.Drawing.SystemColors.ControlText;
			this.link_so1.AutoSize = true;
			this.link_so1.DisabledLinkColor = System.Drawing.SystemColors.ControlText;
			this.link_so1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.link_so1.LinkColor = System.Drawing.SystemColors.ControlText;
			this.link_so1.Location = new System.Drawing.Point(104, 325);
			this.link_so1.Name = "link_so1";
			this.link_so1.Size = new System.Drawing.Size(103, 19);
			this.link_so1.TabIndex = 9;
			this.link_so1.TabStop = true;
			this.link_so1.Text = "SO #65412682";
			this.link_so1.VisitedLinkColor = System.Drawing.SystemColors.ControlText;
			this.link_so1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_so1_LinkClicked);
			// 
			// link_so2
			// 
			this.link_so2.ActiveLinkColor = System.Drawing.SystemColors.ControlText;
			this.link_so2.AutoSize = true;
			this.link_so2.DisabledLinkColor = System.Drawing.SystemColors.ControlText;
			this.link_so2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.link_so2.LinkColor = System.Drawing.SystemColors.ControlText;
			this.link_so2.Location = new System.Drawing.Point(213, 325);
			this.link_so2.Name = "link_so2";
			this.link_so2.Size = new System.Drawing.Size(95, 19);
			this.link_so2.TabIndex = 10;
			this.link_so2.TabStop = true;
			this.link_so2.Text = "SO #7121314";
			this.link_so2.VisitedLinkColor = System.Drawing.SystemColors.ControlText;
			this.link_so2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_so2_LinkClicked);
			// 
			// About
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(347, 362);
			this.Controls.Add(this.label_version);
			this.Controls.Add(this.label_title);
			this.Controls.Add(this.pictureBox_icon);
			this.Controls.Add(this.label_by);
			this.Controls.Add(this.link_milkenm);
			this.Controls.Add(this.label_at);
			this.Controls.Add(this.link_github);
			this.Controls.Add(this.label_info);
			this.Controls.Add(this.link_cpWiki);
			this.Controls.Add(this.link_so1);
			this.Controls.Add(this.link_so2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "About";
			this.Text = "Penguin Miner - About";
			this.Load += new System.EventHandler(this.About_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_icon)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox_icon;
		private System.Windows.Forms.Label label_title;
		private System.Windows.Forms.Label label_by;
		private System.Windows.Forms.LinkLabel link_milkenm;
		private System.Windows.Forms.LinkLabel link_github;
		private System.Windows.Forms.Label label_at;
		private System.Windows.Forms.Label label_version;
		private System.Windows.Forms.Label label_info;
		private System.Windows.Forms.LinkLabel link_cpWiki;
		private System.Windows.Forms.LinkLabel link_so1;
		private System.Windows.Forms.LinkLabel link_so2;
	}
}