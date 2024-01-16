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
