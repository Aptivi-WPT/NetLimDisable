//
// NetLimDisable  Copyright (C) 2023-2024  Aptivi
//
// This file is part of NetLimDisable
//
// NetLimDisable is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// NetLimDisable is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY, without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <https://www.gnu.org/licenses/>.
//

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
