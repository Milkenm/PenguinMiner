
using System.Diagnostics;
using System.Drawing;

using PenguinMiner.Properties;

namespace PenguinMiner
{
	public static class Utils
	{
		public static void ClickAt(int x, int y)
		{
			MouseOperations.SetCursorPosition(x, y);

			MouseOperations.MouseEvent(MouseOperations.MouseEventFlags.LeftDown);
			MouseOperations.MouseEvent(MouseOperations.MouseEventFlags.LeftUp);
		}

		public static bool AreSettingsValid(Point miningPoint1, Point miningPoint2, Point emotes, Point dance, int delay)
		{
			bool validMiningPoint1 = miningPoint1 != null;
			bool validMiningPoint2 = miningPoint2 != null;
			bool validEmotes = emotes != null;
			bool validDance = dance != null;
			bool validDelay = delay >= 500 && delay <= 5000;

			return validMiningPoint1 && validMiningPoint2 && validEmotes && validDance && validDelay;
		}

		public static bool AreSettingsValid()
		{
			return AreSettingsValid(Settings.Default.MiningPoint1, Settings.Default.MiningPoint2, Settings.Default.Actions, Settings.Default.Dance, Settings.Default.Delay);
		}

		public static void OpenLink(string link)
		{
			Process.Start(link);
		}
	}
}
