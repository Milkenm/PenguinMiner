using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using PenguinMiner.Properties;

namespace PenguinMiner.Forms
{
	public partial class Main : Form
	{
		private string CurrentMiningPosition = "left";
		private bool IsMiningEnabled;

		private readonly Color ColorGreen = Color.FromArgb(100, 232, 130);
		private readonly Color ColorRed = Color.FromArgb(232, 100, 100);

		private readonly BackgroundWorker PositionSwitcher = new BackgroundWorker();
		private readonly GlobalHotKey HotKeys = new GlobalHotKey();

		public Main()
		{
			this.InitializeComponent();

			this.SetMinerState(false);
			PositionSwitcher.DoWork += (sender, e) => this.SwitchPosition();

			HotKeys.RegisterHotKey("Alt + M", () => button_mine.PerformClick());
		}

		private void Main_Load(object sender, EventArgs e)
		{
			if (!Utils.AreSettingsValid())
			{
				new Setup().ShowDialog();
			}
		}

		private void button_mine_Click(object sender, EventArgs e)
		{
			if (!Utils.AreSettingsValid())
			{
				MessageBox.Show("Invalid settings detected.");
				new Setup().ShowDialog();
			}
			else
			{
				if (!timer_loop.Enabled)
				{
					timer_loop.Start();
					PositionSwitcher.RunWorkerAsync();
				}
				else
				{
					timer_loop.Stop();
				}
				this.SetMinerState(timer_loop.Enabled);
			}
		}

		private void SetMinerState(bool miningEnabled)
		{
			IsMiningEnabled = miningEnabled;
			if (miningEnabled)
			{
				button_mine.Text = "Stop Mining\n( Alt + M )";
				button_mine.BackColor = ColorRed;
				pictureBox_penguin.Image = Resources.Mining_GIF;
			}
			else
			{
				button_mine.Text = "Start Mining\n( Alt + M )";
				button_mine.BackColor = ColorGreen;
				pictureBox_penguin.Image = Resources.Idle_PNG;
			}
		}

		private void SwitchPosition()
		{
			this.Cursor = new Cursor(Cursor.Current.Handle);
			switch (CurrentMiningPosition)
			{
				case "left":
					this.ClickAt(Settings.Default.MiningPoint1.X, Settings.Default.MiningPoint1.Y);
					CurrentMiningPosition = "right";
					break;
				case "right":
					this.ClickAt(Settings.Default.MiningPoint2.X, Settings.Default.MiningPoint2.Y);
					CurrentMiningPosition = "left";
					break;
			}

			Task.Delay(Settings.Default.Delay).GetAwaiter().GetResult();
			this.ClickAt(Settings.Default.Actions.X, Settings.Default.Actions.Y);
			Task.Delay(10).GetAwaiter().GetResult();
			this.ClickAt(Settings.Default.Dance.X, Settings.Default.Dance.Y);
		}

		private void ClickAt(int x, int y)
		{
			if (IsMiningEnabled)
			{
				Utils.ClickAt(x, y);
			}
		}

		private void timer_loop_Tick(object sender, EventArgs e)
		{
			PositionSwitcher.RunWorkerAsync();
		}

		private void Main_FormClosing(object sender, FormClosingEventArgs e)
		{
			HotKeys.Dispose();
		}

		private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (Application.OpenForms.OfType<Setup>().Count() > 0)
			{
				Setup setup = Application.OpenForms.OfType<Setup>().First();
				setup.WindowState = FormWindowState.Normal;
				setup.Show();
				setup.Focus();
			}
			else
			{
				new Setup().Show();
			}
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (Application.OpenForms.OfType<About>().Count() > 0)
			{
				About about = Application.OpenForms.OfType<About>().First();
				about.WindowState = FormWindowState.Normal;
				about.Show();
				about.Focus();
			}
			else
			{
				new About().Show();
			}
		}
	}
}
