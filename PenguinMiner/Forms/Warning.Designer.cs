namespace PenguinMiner.Forms
{
	partial class Warning
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Warning));
			this.pictureBox_moderator = new System.Windows.Forms.PictureBox();
			this.label_warning = new System.Windows.Forms.Label();
			this.label_disclaimer = new System.Windows.Forms.Label();
			this.link_rules = new System.Windows.Forms.LinkLabel();
			this.button_continue = new System.Windows.Forms.Button();
			this.label_redText = new System.Windows.Forms.Label();
			this.timer_countdown = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_moderator)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox_moderator
			// 
			this.pictureBox_moderator.Image = global::PenguinMiner.Properties.Resources.Moderator_PNG;
			this.pictureBox_moderator.Location = new System.Drawing.Point(103, 23);
			this.pictureBox_moderator.Name = "pictureBox_moderator";
			this.pictureBox_moderator.Size = new System.Drawing.Size(100, 100);
			this.pictureBox_moderator.TabIndex = 0;
			this.pictureBox_moderator.TabStop = false;
			this.pictureBox_moderator.Click += new System.EventHandler(this.pictureBox_moderator_Click);
			// 
			// label_warning
			// 
			this.label_warning.AutoSize = true;
			this.label_warning.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_warning.ForeColor = System.Drawing.Color.White;
			this.label_warning.Location = new System.Drawing.Point(92, 135);
			this.label_warning.Name = "label_warning";
			this.label_warning.Size = new System.Drawing.Size(122, 30);
			this.label_warning.TabIndex = 1;
			this.label_warning.Text = "WARNING";
			// 
			// label_disclaimer
			// 
			this.label_disclaimer.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_disclaimer.ForeColor = System.Drawing.Color.White;
			this.label_disclaimer.Location = new System.Drawing.Point(15, 178);
			this.label_disclaimer.Name = "label_disclaimer";
			this.label_disclaimer.Size = new System.Drawing.Size(276, 192);
			this.label_disclaimer.TabIndex = 2;
			this.label_disclaimer.Text = "The use of this software can lead to a permanent suspension of your account, as i" +
    "t is considered cheating.\r\n\r\n\r\n\r\nThe creators of this software are not responsib" +
    "le for any outcome.\r\n";
			this.label_disclaimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// link_rules
			// 
			this.link_rules.ActiveLinkColor = System.Drawing.Color.White;
			this.link_rules.AutoSize = true;
			this.link_rules.DisabledLinkColor = System.Drawing.Color.White;
			this.link_rules.Font = new System.Drawing.Font("Comic Sans MS", 12F);
			this.link_rules.LinkColor = System.Drawing.Color.White;
			this.link_rules.Location = new System.Drawing.Point(75, 270);
			this.link_rules.Name = "link_rules";
			this.link_rules.Size = new System.Drawing.Size(156, 23);
			this.link_rules.TabIndex = 3;
			this.link_rules.TabStop = true;
			this.link_rules.Text = "Read the rules here.";
			this.link_rules.VisitedLinkColor = System.Drawing.Color.White;
			// 
			// button_continue
			// 
			this.button_continue.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button_continue.Enabled = false;
			this.button_continue.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
			this.button_continue.FlatAppearance.BorderSize = 2;
			this.button_continue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_continue.Font = new System.Drawing.Font("Comic Sans MS", 12F);
			this.button_continue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.button_continue.Location = new System.Drawing.Point(50, 382);
			this.button_continue.Name = "button_continue";
			this.button_continue.Size = new System.Drawing.Size(207, 54);
			this.button_continue.TabIndex = 4;
			this.button_continue.Text = "I still want to use it (15)";
			this.button_continue.UseVisualStyleBackColor = true;
			this.button_continue.Click += new System.EventHandler(this.button_continue_Click);
			// 
			// label_redText
			// 
			this.label_redText.AutoSize = true;
			this.label_redText.Font = new System.Drawing.Font("Comic Sans MS", 12F);
			this.label_redText.ForeColor = System.Drawing.Color.Red;
			this.label_redText.Location = new System.Drawing.Point(47, 205);
			this.label_redText.Name = "label_redText";
			this.label_redText.Size = new System.Drawing.Size(165, 23);
			this.label_redText.TabIndex = 5;
			this.label_redText.Text = "permanent suspension";
			// 
			// timer_countdown
			// 
			this.timer_countdown.Enabled = true;
			this.timer_countdown.Interval = 1000;
			this.timer_countdown.Tick += new System.EventHandler(this.timer_countdown_Tick);
			// 
			// Warning
			// 
			this.AcceptButton = this.button_continue;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.ClientSize = new System.Drawing.Size(306, 460);
			this.Controls.Add(this.pictureBox_moderator);
			this.Controls.Add(this.label_warning);
			this.Controls.Add(this.link_rules);
			this.Controls.Add(this.label_redText);
			this.Controls.Add(this.label_disclaimer);
			this.Controls.Add(this.button_continue);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Warning";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Penguin Miner - Warning";
			this.TopMost = true;
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_moderator)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox_moderator;
		private System.Windows.Forms.Label label_warning;
		private System.Windows.Forms.Label label_disclaimer;
		private System.Windows.Forms.LinkLabel link_rules;
		private System.Windows.Forms.Button button_continue;
		private System.Windows.Forms.Label label_redText;
		private System.Windows.Forms.Timer timer_countdown;
	}
}