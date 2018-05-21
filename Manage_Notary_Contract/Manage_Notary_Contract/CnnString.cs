using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manage_Notary_Contract
{
    public class CnnString
    {
        public static string machineName;
        public static string svName;
        public static string dbName = "Notary_Contract";
        public static string getServerName()
        {
            svName = Environment.MachineName;
            var registryViewArray = new[] { RegistryView.Registry32, RegistryView.Registry64 };
            string s = string.Empty;
            foreach (var registryView in registryViewArray)
            {
                using (var hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, registryView))
                using (var key = hklm.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server"))
                {
                    var instances = (string[])key?.GetValue("InstalledInstances");
                    if (instances != null)
                    {
                        foreach (var element in instances)
                        {
                            if (element == "MSSQLSERVER")
                                s = System.Environment.MachineName;
                            else
                                s = System.Environment.MachineName + @"\" + element;
                        }
                    }
                }
            }

            return svName = s;
        }

    }
}