using System;
using System.Drawing;
using System.Windows.Forms;

using PenguinMiner.Properties;

namespace PenguinMiner.Forms
{
	public partial class Setup : Form
	{
		private Setting? CurrentSetting = null;

		private Point MiningPoint1 = new Point(0, 0);
		private Point MiningPoint2 = new Point(0, 0);
		private Point ActionsPoint = new Point(0, 0);
		private Point DanceEmotePoint = new Point(0, 0);

		private readonly GlobalHotKey HotKeys = new GlobalHotKey();

		public Setup()
		{
			this.InitializeComponent();
			HotKeys.RegisterHotKey("Alt + X", () => this.RegisterPoint());

			MiningPoint1 = Settings.Default.MiningPoint1;
			MiningPoint2 = Settings.Default.MiningPoint2;
			ActionsPoint = Settings.Default.Actions;
			DanceEmotePoint = Settings.Default.Dance;
			numeric_delay.Value = Settings.Default.Delay;
			this.RefreshPoints();
		}

		private void RefreshPoints()
		{
			numeric_x1.Value = MiningPoint1.X;
			numeric_y1.Value = MiningPoint1.Y;

			numeric_x2.Value = MiningPoint2.X;
			numeric_y2.Value = MiningPoint2.Y;

			numeric_actionsX.Value = ActionsPoint.X;
			numeric_actionsY.Value = ActionsPoint.Y;

			numeric_danceX.Value = DanceEmotePoint.X;
			numeric_danceY.Value = DanceEmotePoint.Y;
		}

		private void Setup_FormClosing(object sender, FormClosingEventArgs e)
		{
			HotKeys.Dispose();
		}

		private void RegisterPoint()
		{
			Point point = new Point(MouseOperations.GetCursorPosition().X, MouseOperations.GetCursorPosition().Y);

			switch (CurrentSetting)
			{
				case Setting.MiningPoint1:
					MiningPoint1 = point;
					this.ButtonClick(1);
					break;
				case Setting.MiningPoint2:
					MiningPoint2 = point;
					this.ButtonClick(2);
					break;
				case Setting.ActionsButton:
					ActionsPoint = point;
					this.ButtonClick(3);
					break;
				case Setting.DanceEmote:
					DanceEmotePoint = point;
					this.ButtonClick(4);
					break;
			}

			this.RefreshPoints();
		}

		private Setting? previousSetting;
		private void timer_coordinates_Tick(object sender, EventArgs e)
		{
			int x = MouseOperations.GetCursorPosition().X;
			int y = MouseOperations.GetCursorPosition().Y;

			if (previousSetting != CurrentSetting)
			{
				previousSetting = CurrentSetting;

				numeric_x1.Value = MiningPoint1.X;
				numeric_y1.Value = MiningPoint1.Y;

				numeric_x2.Value = MiningPoint2.X;
				numeric_y2.Value = MiningPoint2.Y;

				numeric_actionsX.Value = ActionsPoint.X;
				numeric_actionsY.Value = ActionsPoint.Y;

				numeric_danceX.Value = DanceEmotePoint.X;
				numeric_danceY.Value = DanceEmotePoint.Y;
			}

			if (CurrentSetting == Setting.MiningPoint1)
			{
				numeric_x1.Value = x;
				numeric_y1.Value = y;
			}
			else if (CurrentSetting == Setting.MiningPoint2)
			{
				numeric_x2.Value = x;
				numeric_y2.Value = y;
			}
			else if (CurrentSetting == Setting.ActionsButton)
			{
				numeric_actionsX.Value = x;
				numeric_actionsY.Value = y;
			}
			else if (CurrentSetting == Setting.DanceEmote)
			{
				numeric_danceX.Value = x;
				numeric_danceY.Value = y;
			}
		}

		public enum Setting
		{
			MiningPoint1,
			MiningPoint2,
			ActionsButton,
			DanceEmote,
		}

		private void Button_SetPoint(object sender, EventArgs e)
		{
			if (((Button)sender).Name == button_changePoint1.Name)
			{
				this.ButtonClick(1);
			}
			else if (((Button)sender).Name == button_changePoint2.Name)
			{
				this.ButtonClick(2);
			}
			else if (((Button)sender).Name == button_changeActions.Name)
			{
				this.ButtonClick(3);
			}
			else if (((Button)sender).Name == button_changeDance.Name)
			{
				this.ButtonClick(4);
			}
		}

		private void ButtonClick(int index)
		{
			this.SetButtonState(button_changePoint1, false);
			this.SetButtonState(button_changePoint2, false);
			this.SetButtonState(button_changeActions, false);
			this.SetButtonState(button_changeDance, false);

			Setting? setting = null;
			if (index == 1)
			{
				setting = Setting.MiningPoint1;
			}
			else if (index == 2)
			{
				setting = Setting.MiningPoint2;
			}
			else if (index == 3)
			{
				setting = Setting.ActionsButton;
			}
			else if (index == 4)
			{
				setting = Setting.DanceEmote;
			}

			if (CurrentSetting != setting)
			{
				CurrentSetting = setting;

				if (setting == Setting.MiningPoint1)
				{
					this.SetButtonState(button_changePoint1, true);
				}
				else if (setting == Setting.MiningPoint2)
				{
					this.SetButtonState(button_changePoint2, true);
				}
				else if (setting == Setting.ActionsButton)
				{
					this.SetButtonState(button_changeActions, true);
				}
				else if (setting == Setting.DanceEmote)
				{
					this.SetButtonState(button_changeDance, true);
				}
			}
			else
			{
				CurrentSetting = null;
			}
		}

		private void SetButtonState(Button button, bool isSelecting)
		{
			if (isSelecting)
			{
				button.Text = "Press\nAlt + X";
				button.BackColor = Color.LightSkyBlue;
			}
			else
			{
				button.Text = "Change";
				button.BackColor = Color.FromArgb(225, 225, 225);
			}
		}

		private void button_cancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button_save_Click(object sender, EventArgs e)
		{
			this.SaveSettings(true);
		}

		private void button_apply_Click(object sender, EventArgs e)
		{
			this.SaveSettings(false);
		}

		private void SaveSettings(bool closeOnSave)
		{
			bool areSettingsValid = Utils.AreSettingsValid(MiningPoint1, MiningPoint2, ActionsPoint, DanceEmotePoint, (int)numeric_delay.Value);

			if (areSettingsValid)
			{
				Settings.Default.MiningPoint1 = MiningPoint1;
				Settings.Default.MiningPoint2 = MiningPoint2;
				Settings.Default.Actions = ActionsPoint;
				Settings.Default.Dance = DanceEmotePoint;
				Settings.Default.Delay = (int)numeric_delay.Value;
				Settings.Default.Save();
				if (closeOnSave)
				{
					button_cancel.PerformClick();
				}
			}
			else
			{
				MessageBox.Show("Invalid settings detected");
			}
		}
	}
}
