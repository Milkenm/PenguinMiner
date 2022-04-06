using System;
using System.Windows.Forms;

using PenguinMiner.Properties;

namespace PenguinMiner.Forms
{
	public partial class Warning : Form
	{
		private int CountDown = 15;
		private int DisableWarningClicker = 50;

		public Warning()
		{
			this.InitializeComponent();
		}

		private void timer_countdown_Tick(object sender, EventArgs e)
		{
			CountDown--;
			if (CountDown <= 0)
			{
				button_continue.Text = "I still want to use it";
				button_continue.Enabled = true;
				timer_countdown.Stop();
				return;
			}
			button_continue.Text = $"I still want to use it ({CountDown})";
		}

		private void button_continue_Click(object sender, EventArgs e)
		{
			Program.continueToMain = true;
			this.Close();
		}

		private void pictureBox_moderator_Click(object sender, EventArgs e)
		{
			DisableWarningClicker--;
			if (DisableWarningClicker <= 0)
			{
				pictureBox_moderator.Image = Resources.BrokenModerator_PNG;
				CountDown = 0;
			}
			Settings.Default.IsWarningEnabled = false;
			Settings.Default.Save();
		}
	}
}
