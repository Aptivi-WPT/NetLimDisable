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

using Microsoft.Win32;
using System;
using System.Security.Principal;
using System.Windows.Forms;

namespace NetLimDisable.Tools
{
	public static class NetLimTools
	{
		public static bool IsLimitedDisconnectEnabled()
		{
			// Check the value of HKLM\SOFTWARE\Microsoft\WcmSvc\EnableBadStateTracking
			RegistryKey baseKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32);
			RegistryKey regkey = baseKey.OpenSubKey(@"SOFTWARE\Microsoft\WcmSvc");
			if (regkey == null)
				return true;
			int enabledInt = (int)regkey.GetValue("EnableBadStateTracking", 1);
			bool enabled = enabledInt == 1;
            regkey.Dispose();
            baseKey.Dispose();
			return enabled;
		}

		public static void SetLimitedDisconnect(bool enabled)
		{
			// Check the value of HKLM\SOFTWARE\Microsoft\WcmSvc\EnableBadStateTracking
			RegistryKey baseKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32);
			RegistryKey regkey = baseKey.OpenSubKey(@"SOFTWARE\Microsoft\WcmSvc", true);

			// Set the value!
			regkey.SetValue(@"EnableBadStateTracking", enabled ? 1 : 0, RegistryValueKind.DWord);
			if (enabled)
				MessageBox.Show("Enabled successfully.");
			else
				MessageBox.Show("Disabled successfully.");
            regkey.Dispose();
            baseKey.Dispose();
        }

		public static bool IsUserAuthorized()
		{
			// Check for admin privileges
			var identity = WindowsIdentity.GetCurrent();
			var principal = new WindowsPrincipal(identity);
			return principal.IsInRole(WindowsBuiltInRole.Administrator);
		}

        public static bool IsUserOnWindows()
        {
            return Environment.OSVersion.Platform == PlatformID.Win32NT;
        }
    }
}
