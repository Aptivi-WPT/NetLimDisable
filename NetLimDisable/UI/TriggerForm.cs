using NetLimDisable.Tools;
using System.Windows.Forms;

namespace NetLimDisable
{
	public partial class TriggerForm : Form
	{
		public TriggerForm()
		{
			InitializeComponent();
			netLimDisable.Checked = !NetLimTools.IsLimitedDisconnectEnabled();
		}

		private void applyButton_Click(object sender, System.EventArgs e)
		{
			NetLimTools.SetLimitedDisconnect(!netLimDisable.Checked);
		}

		private void aboutButton_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show(
				"Aptivi Windows PowerTools - NetLimTools v1.0" + "\n" +
                "Copyright (c) 2024 Aptivi - All rights reserved." + "\n" +
                "" + "\n" +
                "NetLimTools is a program that reduces the WLAN AutoConfig disconnections caused by" +
                "\"limited connectivity.\" This works in situations where VPNs are needed for heavy" +
                "operations or where your computer is connected to an unstable network." + "\n" +
                "" + "\n" +
                "This reduces the AutoConfig disconnections with \"Trigger Reason: 5\""
				, "About NetLimTools", MessageBoxButtons.OK, MessageBoxIcon.Information
			);
		}
	}
}
