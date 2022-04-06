namespace PenguinMiner.Forms
{
	partial class Setup
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setup));
			this.groupBox_miningPoint1 = new System.Windows.Forms.GroupBox();
			this.label_x1 = new System.Windows.Forms.Label();
			this.numeric_x1 = new System.Windows.Forms.NumericUpDown();
			this.label_y1 = new System.Windows.Forms.Label();
			this.numeric_y1 = new System.Windows.Forms.NumericUpDown();
			this.button_changePoint1 = new System.Windows.Forms.Button();
			this.groupBox_miningPoint2 = new System.Windows.Forms.GroupBox();
			this.label_x2 = new System.Windows.Forms.Label();
			this.numeric_x2 = new System.Windows.Forms.NumericUpDown();
			this.label_y2 = new System.Windows.Forms.Label();
			this.numeric_y2 = new System.Windows.Forms.NumericUpDown();
			this.button_changePoint2 = new System.Windows.Forms.Button();
			this.button_cancel = new System.Windows.Forms.Button();
			this.button_save = new System.Windows.Forms.Button();
			this.timer_coordinates = new System.Windows.Forms.Timer(this.components);
			this.groupBox_actionsButton = new System.Windows.Forms.GroupBox();
			this.label_actionsX = new System.Windows.Forms.Label();
			this.numeric_actionsX = new System.Windows.Forms.NumericUpDown();
			this.label_actionsY = new System.Windows.Forms.Label();
			this.numeric_actionsY = new System.Windows.Forms.NumericUpDown();
			this.button_changeActions = new System.Windows.Forms.Button();
			this.groupBox_danceEmote = new System.Windows.Forms.GroupBox();
			this.label_danceX = new System.Windows.Forms.Label();
			this.numeric_danceX = new System.Windows.Forms.NumericUpDown();
			this.label_danceY = new System.Windows.Forms.Label();
			this.numeric_danceY = new System.Windows.Forms.NumericUpDown();
			this.button_changeDance = new System.Windows.Forms.Button();
			this.numeric_delay = new System.Windows.Forms.NumericUpDown();
			this.label_delay = new System.Windows.Forms.Label();
			this.button_apply = new System.Windows.Forms.Button();
			this.groupBox_miningPoint1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numeric_x1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numeric_y1)).BeginInit();
			this.groupBox_miningPoint2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numeric_x2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numeric_y2)).BeginInit();
			this.groupBox_actionsButton.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numeric_actionsX)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numeric_actionsY)).BeginInit();
			this.groupBox_danceEmote.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numeric_danceX)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numeric_danceY)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numeric_delay)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox_miningPoint1
			// 
			this.groupBox_miningPoint1.Controls.Add(this.label_x1);
			this.groupBox_miningPoint1.Controls.Add(this.numeric_x1);
			this.groupBox_miningPoint1.Controls.Add(this.label_y1);
			this.groupBox_miningPoint1.Controls.Add(this.numeric_y1);
			this.groupBox_miningPoint1.Controls.Add(this.button_changePoint1);
			this.groupBox_miningPoint1.Location = new System.Drawing.Point(16, 14);
			this.groupBox_miningPoint1.Name = "groupBox_miningPoint1";
			this.groupBox_miningPoint1.Size = new System.Drawing.Size(272, 96);
			this.groupBox_miningPoint1.TabIndex = 0;
			this.groupBox_miningPoint1.TabStop = false;
			this.groupBox_miningPoint1.Text = "Mining Point 1";
			// 
			// label_x1
			// 
			this.label_x1.AutoSize = true;
			this.label_x1.Location = new System.Drawing.Point(22, 30);
			this.label_x1.Name = "label_x1";
			this.label_x1.Size = new System.Drawing.Size(17, 13);
			this.label_x1.TabIndex = 2;
			this.label_x1.Text = "X:";
			// 
			// numeric_x1
			// 
			this.numeric_x1.Font = new System.Drawing.Font("Bumbastika", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numeric_x1.Location = new System.Drawing.Point(45, 24);
			this.numeric_x1.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
			this.numeric_x1.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
			this.numeric_x1.Name = "numeric_x1";
			this.numeric_x1.ReadOnly = true;
			this.numeric_x1.Size = new System.Drawing.Size(120, 25);
			this.numeric_x1.TabIndex = 0;
			this.numeric_x1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label_y1
			// 
			this.label_y1.AutoSize = true;
			this.label_y1.Location = new System.Drawing.Point(22, 61);
			this.label_y1.Name = "label_y1";
			this.label_y1.Size = new System.Drawing.Size(17, 13);
			this.label_y1.TabIndex = 3;
			this.label_y1.Text = "Y:";
			// 
			// numeric_y1
			// 
			this.numeric_y1.Font = new System.Drawing.Font("Bumbastika", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numeric_y1.Location = new System.Drawing.Point(45, 55);
			this.numeric_y1.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
			this.numeric_y1.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
			this.numeric_y1.Name = "numeric_y1";
			this.numeric_y1.ReadOnly = true;
			this.numeric_y1.Size = new System.Drawing.Size(120, 25);
			this.numeric_y1.TabIndex = 1;
			this.numeric_y1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// button_changePoint1
			// 
			this.button_changePoint1.Location = new System.Drawing.Point(195, 24);
			this.button_changePoint1.Name = "button_changePoint1";
			this.button_changePoint1.Size = new System.Drawing.Size(56, 56);
			this.button_changePoint1.TabIndex = 1;
			this.button_changePoint1.Text = "Change";
			this.button_changePoint1.UseVisualStyleBackColor = true;
			this.button_changePoint1.Click += new System.EventHandler(this.Button_SetPoint);
			// 
			// groupBox_miningPoint2
			// 
			this.groupBox_miningPoint2.Controls.Add(this.label_x2);
			this.groupBox_miningPoint2.Controls.Add(this.numeric_x2);
			this.groupBox_miningPoint2.Controls.Add(this.label_y2);
			this.groupBox_miningPoint2.Controls.Add(this.numeric_y2);
			this.groupBox_miningPoint2.Controls.Add(this.button_changePoint2);
			this.groupBox_miningPoint2.Location = new System.Drawing.Point(294, 14);
			this.groupBox_miningPoint2.Name = "groupBox_miningPoint2";
			this.groupBox_miningPoint2.Size = new System.Drawing.Size(272, 96);
			this.groupBox_miningPoint2.TabIndex = 1;
			this.groupBox_miningPoint2.TabStop = false;
			this.groupBox_miningPoint2.Text = "Mining Point 2";
			// 
			// label_x2
			// 
			this.label_x2.AutoSize = true;
			this.label_x2.Location = new System.Drawing.Point(22, 30);
			this.label_x2.Name = "label_x2";
			this.label_x2.Size = new System.Drawing.Size(17, 13);
			this.label_x2.TabIndex = 2;
			this.label_x2.Text = "X:";
			// 
			// numeric_x2
			// 
			this.numeric_x2.Font = new System.Drawing.Font("Bumbastika", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numeric_x2.Location = new System.Drawing.Point(45, 24);
			this.numeric_x2.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
			this.numeric_x2.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
			this.numeric_x2.Name = "numeric_x2";
			this.numeric_x2.ReadOnly = true;
			this.numeric_x2.Size = new System.Drawing.Size(120, 25);
			this.numeric_x2.TabIndex = 0;
			this.numeric_x2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label_y2
			// 
			this.label_y2.AutoSize = true;
			this.label_y2.Location = new System.Drawing.Point(22, 61);
			this.label_y2.Name = "label_y2";
			this.label_y2.Size = new System.Drawing.Size(17, 13);
			this.label_y2.TabIndex = 3;
			this.label_y2.Text = "Y:";
			// 
			// numeric_y2
			// 
			this.numeric_y2.Font = new System.Drawing.Font("Bumbastika", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numeric_y2.Location = new System.Drawing.Point(45, 55);
			this.numeric_y2.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
			this.numeric_y2.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
			this.numeric_y2.Name = "numeric_y2";
			this.numeric_y2.ReadOnly = true;
			this.numeric_y2.Size = new System.Drawing.Size(120, 25);
			this.numeric_y2.TabIndex = 1;
			this.numeric_y2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// button_changePoint2
			// 
			this.button_changePoint2.Location = new System.Drawing.Point(195, 24);
			this.button_changePoint2.Name = "button_changePoint2";
			this.button_changePoint2.Size = new System.Drawing.Size(56, 56);
			this.button_changePoint2.TabIndex = 1;
			this.button_changePoint2.Text = "Change";
			this.button_changePoint2.UseVisualStyleBackColor = true;
			this.button_changePoint2.Click += new System.EventHandler(this.Button_SetPoint);
			// 
			// button_cancel
			// 
			this.button_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button_cancel.Location = new System.Drawing.Point(491, 227);
			this.button_cancel.Name = "button_cancel";
			this.button_cancel.Size = new System.Drawing.Size(75, 23);
			this.button_cancel.TabIndex = 2;
			this.button_cancel.Text = "Cancel";
			this.button_cancel.UseVisualStyleBackColor = true;
			this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
			// 
			// button_save
			// 
			this.button_save.Location = new System.Drawing.Point(329, 227);
			this.button_save.Name = "button_save";
			this.button_save.Size = new System.Drawing.Size(75, 23);
			this.button_save.TabIndex = 3;
			this.button_save.Text = "Save";
			this.button_save.UseVisualStyleBackColor = true;
			this.button_save.Click += new System.EventHandler(this.button_save_Click);
			// 
			// timer_coordinates
			// 
			this.timer_coordinates.Enabled = true;
			this.timer_coordinates.Interval = 3;
			this.timer_coordinates.Tick += new System.EventHandler(this.timer_coordinates_Tick);
			// 
			// groupBox_actionsButton
			// 
			this.groupBox_actionsButton.Controls.Add(this.label_actionsX);
			this.groupBox_actionsButton.Controls.Add(this.numeric_actionsX);
			this.groupBox_actionsButton.Controls.Add(this.label_actionsY);
			this.groupBox_actionsButton.Controls.Add(this.numeric_actionsY);
			this.groupBox_actionsButton.Controls.Add(this.button_changeActions);
			this.groupBox_actionsButton.Location = new System.Drawing.Point(16, 116);
			this.groupBox_actionsButton.Name = "groupBox_actionsButton";
			this.groupBox_actionsButton.Size = new System.Drawing.Size(272, 96);
			this.groupBox_actionsButton.TabIndex = 4;
			this.groupBox_actionsButton.TabStop = false;
			this.groupBox_actionsButton.Text = "Actions Button";
			// 
			// label_actionsX
			// 
			this.label_actionsX.AutoSize = true;
			this.label_actionsX.Location = new System.Drawing.Point(22, 30);
			this.label_actionsX.Name = "label_actionsX";
			this.label_actionsX.Size = new System.Drawing.Size(17, 13);
			this.label_actionsX.TabIndex = 2;
			this.label_actionsX.Text = "X:";
			// 
			// numeric_actionsX
			// 
			this.numeric_actionsX.Font = new System.Drawing.Font("Bumbastika", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numeric_actionsX.Location = new System.Drawing.Point(45, 24);
			this.numeric_actionsX.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
			this.numeric_actionsX.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
			this.numeric_actionsX.Name = "numeric_actionsX";
			this.numeric_actionsX.ReadOnly = true;
			this.numeric_actionsX.Size = new System.Drawing.Size(120, 25);
			this.numeric_actionsX.TabIndex = 0;
			this.numeric_actionsX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label_actionsY
			// 
			this.label_actionsY.AutoSize = true;
			this.label_actionsY.Location = new System.Drawing.Point(22, 61);
			this.label_actionsY.Name = "label_actionsY";
			this.label_actionsY.Size = new System.Drawing.Size(17, 13);
			this.label_actionsY.TabIndex = 3;
			this.label_actionsY.Text = "Y:";
			// 
			// numeric_actionsY
			// 
			this.numeric_actionsY.Font = new System.Drawing.Font("Bumbastika", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numeric_actionsY.Location = new System.Drawing.Point(45, 55);
			this.numeric_actionsY.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
			this.numeric_actionsY.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
			this.numeric_actionsY.Name = "numeric_actionsY";
			this.numeric_actionsY.ReadOnly = true;
			this.numeric_actionsY.Size = new System.Drawing.Size(120, 25);
			this.numeric_actionsY.TabIndex = 1;
			this.numeric_actionsY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// button_changeActions
			// 
			this.button_changeActions.Location = new System.Drawing.Point(195, 24);
			this.button_changeActions.Name = "button_changeActions";
			this.button_changeActions.Size = new System.Drawing.Size(56, 56);
			this.button_changeActions.TabIndex = 1;
			this.button_changeActions.Text = "Change";
			this.button_changeActions.UseVisualStyleBackColor = true;
			this.button_changeActions.Click += new System.EventHandler(this.Button_SetPoint);
			// 
			// groupBox_danceEmote
			// 
			this.groupBox_danceEmote.Controls.Add(this.label_danceX);
			this.groupBox_danceEmote.Controls.Add(this.numeric_danceX);
			this.groupBox_danceEmote.Controls.Add(this.label_danceY);
			this.groupBox_danceEmote.Controls.Add(this.numeric_danceY);
			this.groupBox_danceEmote.Controls.Add(this.button_changeDance);
			this.groupBox_danceEmote.Location = new System.Drawing.Point(294, 116);
			this.groupBox_danceEmote.Name = "groupBox_danceEmote";
			this.groupBox_danceEmote.Size = new System.Drawing.Size(272, 96);
			this.groupBox_danceEmote.TabIndex = 4;
			this.groupBox_danceEmote.TabStop = false;
			this.groupBox_danceEmote.Text = "Dance Emote";
			// 
			// label_danceX
			// 
			this.label_danceX.AutoSize = true;
			this.label_danceX.Location = new System.Drawing.Point(22, 30);
			this.label_danceX.Name = "label_danceX";
			this.label_danceX.Size = new System.Drawing.Size(17, 13);
			this.label_danceX.TabIndex = 2;
			this.label_danceX.Text = "X:";
			// 
			// numeric_danceX
			// 
			this.numeric_danceX.Font = new System.Drawing.Font("Bumbastika", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numeric_danceX.Location = new System.Drawing.Point(45, 24);
			this.numeric_danceX.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
			this.numeric_danceX.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
			this.numeric_danceX.Name = "numeric_danceX";
			this.numeric_danceX.ReadOnly = true;
			this.numeric_danceX.Size = new System.Drawing.Size(120, 25);
			this.numeric_danceX.TabIndex = 0;
			this.numeric_danceX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label_danceY
			// 
			this.label_danceY.AutoSize = true;
			this.label_danceY.Location = new System.Drawing.Point(22, 61);
			this.label_danceY.Name = "label_danceY";
			this.label_danceY.Size = new System.Drawing.Size(17, 13);
			this.label_danceY.TabIndex = 3;
			this.label_danceY.Text = "Y:";
			// 
			// numeric_danceY
			// 
			this.numeric_danceY.Font = new System.Drawing.Font("Bumbastika", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numeric_danceY.Location = new System.Drawing.Point(45, 55);
			this.numeric_danceY.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
			this.numeric_danceY.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
			this.numeric_danceY.Name = "numeric_danceY";
			this.numeric_danceY.ReadOnly = true;
			this.numeric_danceY.Size = new System.Drawing.Size(120, 25);
			this.numeric_danceY.TabIndex = 1;
			this.numeric_danceY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// button_changeDance
			// 
			this.button_changeDance.Location = new System.Drawing.Point(195, 24);
			this.button_changeDance.Name = "button_changeDance";
			this.button_changeDance.Size = new System.Drawing.Size(56, 56);
			this.button_changeDance.TabIndex = 1;
			this.button_changeDance.Text = "Change";
			this.button_changeDance.UseVisualStyleBackColor = true;
			this.button_changeDance.Click += new System.EventHandler(this.Button_SetPoint);
			// 
			// numeric_delay
			// 
			this.numeric_delay.Font = new System.Drawing.Font("Bumbastika", 8.249999F);
			this.numeric_delay.Location = new System.Drawing.Point(61, 225);
			this.numeric_delay.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
			this.numeric_delay.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
			this.numeric_delay.Name = "numeric_delay";
			this.numeric_delay.Size = new System.Drawing.Size(120, 25);
			this.numeric_delay.TabIndex = 5;
			this.numeric_delay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numeric_delay.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
			// 
			// label_delay
			// 
			this.label_delay.AutoSize = true;
			this.label_delay.Location = new System.Drawing.Point(18, 231);
			this.label_delay.Name = "label_delay";
			this.label_delay.Size = new System.Drawing.Size(37, 13);
			this.label_delay.TabIndex = 6;
			this.label_delay.Text = "Delay:";
			// 
			// button_apply
			// 
			this.button_apply.Location = new System.Drawing.Point(410, 227);
			this.button_apply.Name = "button_apply";
			this.button_apply.Size = new System.Drawing.Size(75, 23);
			this.button_apply.TabIndex = 7;
			this.button_apply.Text = "Apply";
			this.button_apply.UseVisualStyleBackColor = true;
			this.button_apply.Click += new System.EventHandler(this.button_apply_Click);
			// 
			// Setup
			// 
			this.AcceptButton = this.button_save;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.button_cancel;
			this.ClientSize = new System.Drawing.Size(583, 262);
			this.Controls.Add(this.groupBox_miningPoint1);
			this.Controls.Add(this.groupBox_miningPoint2);
			this.Controls.Add(this.groupBox_actionsButton);
			this.Controls.Add(this.groupBox_danceEmote);
			this.Controls.Add(this.label_delay);
			this.Controls.Add(this.numeric_delay);
			this.Controls.Add(this.button_save);
			this.Controls.Add(this.button_apply);
			this.Controls.Add(this.button_cancel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Setup";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Penguin Miner - Setup";
			this.TopMost = true;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Setup_FormClosing);
			this.groupBox_miningPoint1.ResumeLayout(false);
			this.groupBox_miningPoint1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numeric_x1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numeric_y1)).EndInit();
			this.groupBox_miningPoint2.ResumeLayout(false);
			this.groupBox_miningPoint2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numeric_x2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numeric_y2)).EndInit();
			this.groupBox_actionsButton.ResumeLayout(false);
			this.groupBox_actionsButton.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numeric_actionsX)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numeric_actionsY)).EndInit();
			this.groupBox_danceEmote.ResumeLayout(false);
			this.groupBox_danceEmote.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numeric_danceX)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numeric_danceY)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numeric_delay)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox_miningPoint1;
		private System.Windows.Forms.NumericUpDown numeric_y1;
		private System.Windows.Forms.NumericUpDown numeric_x1;
		private System.Windows.Forms.Button button_changePoint1;
		private System.Windows.Forms.Label label_y1;
		private System.Windows.Forms.Label label_x1;
		private System.Windows.Forms.GroupBox groupBox_miningPoint2;
		private System.Windows.Forms.Button button_changePoint2;
		private System.Windows.Forms.Label label_y2;
		private System.Windows.Forms.NumericUpDown numeric_y2;
		private System.Windows.Forms.Label label_x2;
		private System.Windows.Forms.NumericUpDown numeric_x2;
		private System.Windows.Forms.Button button_cancel;
		private System.Windows.Forms.Button button_save;
		private System.Windows.Forms.Timer timer_coordinates;
		private System.Windows.Forms.GroupBox groupBox_actionsButton;
		private System.Windows.Forms.Button button_changeActions;
		private System.Windows.Forms.Label label_actionsY;
		private System.Windows.Forms.NumericUpDown numeric_actionsY;
		private System.Windows.Forms.Label label_actionsX;
		private System.Windows.Forms.NumericUpDown numeric_actionsX;
		private System.Windows.Forms.GroupBox groupBox_danceEmote;
		private System.Windows.Forms.Button button_changeDance;
		private System.Windows.Forms.Label label_danceY;
		private System.Windows.Forms.NumericUpDown numeric_danceY;
		private System.Windows.Forms.Label label_danceX;
		private System.Windows.Forms.NumericUpDown numeric_danceX;
		private System.Windows.Forms.NumericUpDown numeric_delay;
		private System.Windows.Forms.Label label_delay;
		private System.Windows.Forms.Button button_apply;
	}
}