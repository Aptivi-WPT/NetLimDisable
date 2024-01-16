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
