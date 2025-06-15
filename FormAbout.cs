
using System.Reflection;

namespace OGMiner
{
	public partial class FormAbout : Form
	{
		static int year = 2025;
		static string author = "Andorianin";

		public FormAbout(string lang)
		{
			InitializeComponent();

			button1.Text = Loca.GetString(lang, "CLOSE");
			label1.Text = Loca.GetString(lang, "ABOUT", Assembly.GetExecutingAssembly().GetName().Version.ToString(), year.ToString(), author);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}