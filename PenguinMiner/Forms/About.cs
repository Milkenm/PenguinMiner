using System.Windows.Forms;

namespace PenguinMiner.Forms
{
	public partial class About : Form
	{
		public About()
		{
			this.InitializeComponent();
		}

		private void About_Load(object sender, System.EventArgs e)
		{
			string[] versions = Application.ProductVersion.Split('.');
			label_version.Text = $"v{versions[0]}.{versions[1]}";
		}

		private void link_milkenm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Utils.OpenLink("http://www.github.com/Milkenm");
		}

		private void link_github_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Utils.OpenLink("http://www.github.com/Milkenm/PenguinMiner");
		}

		private void link_cpWiki_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Utils.OpenLink("https://clubpenguinrewritten.fandom.com/wiki/Club_Penguin_Rewritten_Wiki");
		}

		private void link_so1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Utils.OpenLink("https://stackoverflow.com/a/65412682");
		}

		private void link_so2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Utils.OpenLink("https://stackoverflow.com/a/7121314");
		}
	}
}
