using System;
using System.Windows.Forms;

using PenguinMiner.Forms;
using PenguinMiner.Properties;

namespace PenguinMiner
{
	internal static class Program
	{
		public static bool continueToMain = false;

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			if (Settings.Default.IsWarningEnabled)
			{
				Application.Run(new Warning());
			}

			if (!Settings.Default.IsWarningEnabled || continueToMain)
			{
				Application.Run(new Main());
			}
		}
	}
}
