using System;

namespace FLNotePad
{
    /// <summary>
    /// Allows you to quickly access data stored in the registry for Freelancer
    /// and various Freelancer modification support tools.
    /// </summary>
    public class RegistryData
    {
        Microsoft.Win32.RegistryKey machineKey =
            Microsoft.Win32.Registry.LocalMachine;
        Microsoft.Win32.RegistryKey userKey =
            Microsoft.Win32.Registry.CurrentUser;
        // standard subpath for Freelancer registry information
        string FreelancerRegPath =
            "Software\\Microsoft\\Microsoft Games\\Freelancer\\1.0";
        string ModManagerRegPath =
            "SOFTWARE\\Freelancer Mod Manager";
        string SdkRegPath =
            "SOFTWARE\\FreelancerSDK";

        /// <summary>
        /// Location where Freelancer is installed
        /// </summary>
        public string InstallPath {
            get {
                machineKey.OpenSubKey(FreelancerRegPath);
                return ((string)machineKey.GetValue("AppPath"));
            }
        }

        /// <summary>
        /// Location where Freelancer Mod Manager is installed
        /// </summary>
        public string FlmmPath {
            get {
                machineKey.OpenSubKey(ModManagerRegPath);
                return ((string)machineKey.GetValue("Install_Dir"));
            }
        }

        /// <summary>
        /// Location where Freelancer SDK is installed
        /// </summary>
        public string SDKPath {
            get {
                machineKey.OpenSubKey(SdkRegPath);
                return ((string)machineKey.GetValue("Path"));
            }
        }



    }
}
