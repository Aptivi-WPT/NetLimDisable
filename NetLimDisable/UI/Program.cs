using NetLimDisable.Tools;
using System;
using System.Windows.Forms;

namespace NetLimDisable
{
	internal static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			if (!NetLimTools.IsUserOnWindows())
				MessageBox.Show("NetLimDisable only works for Windows 10 and higher. " + Environment.OSVersion.Platform.ToString() + " is not supported by this program.", "OS Unsupported", MessageBoxButtons.OK, MessageBoxIcon.Error);
			else if (Environment.OSVersion.Version.Major < 10)
				MessageBox.Show("NetLimDisable only works for Windows 10 and higher. Your system doesn't automatically disconnect when 'limited connection' is detected. We apologize for your inconvenience.", "OS Unsupported", MessageBoxButtons.OK, MessageBoxIcon.Error);
			else if (!NetLimTools.IsUserAuthorized())
				MessageBox.Show("NetLimDisable needs administrator privileges as it makes changes to the registry.", "Unauthorized!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			else
				Application.Run(new TriggerForm());
		}
	}
}
