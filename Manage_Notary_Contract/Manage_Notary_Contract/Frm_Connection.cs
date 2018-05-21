using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Sql;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Manage_Notary_Contract
{
    public partial class Frm_Connection : Form
    {
        public Frm_Connection()
        {
            InitializeComponent();
        }

        public Cl_Database db = new Cl_Database();
        DataTable table;
        BLL_ServerName bll_serverName;
        public string err = string.Empty;

        private void bttCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_Login logIn = new Frm_Login();
            logIn.Show();
        }

        private void bttTestConnection_Click(object sender, EventArgs e)
        {
            if (cbbDatabaseName.SelectedIndex == -1)
            {
                MessageBox.Show("Please choose any database in your server.");
            }
            else
            {
                MessageBox.Show("Test connection succeeded.");
            }
        }

        private void bttConnect_Click(object sender, EventArgs e)
        {
            if (cbbDatabaseName.SelectedIndex == -1)
            {
                MessageBox.Show("Please choose any database in your server.");
                return;
            }
            if (string.Compare(cbbDatabaseName.SelectedItem.ToString(), "Notary_Contract") == 0)
            {
                this.Hide();
                DialogResult res = MessageBox.Show(db.KiemTraKetNoi(ref err) ? "Connected" : "Fail\n" + err);
                if (res == DialogResult.OK)
                {
                    Frm_Main main = new Frm_Main();
                    main.Show();
                }
            }
            else
            {
                MessageBox.Show("You need to choose a compatible database for your project.");
            }
        }

        private void Frm_Connection_Load(object sender, EventArgs e)
        {
            string s = null;
            bll_serverName = new BLL_ServerName();
            load_server_name(ref s);
            cbo_servreName.SelectedIndex = 0;
            cbbDatabaseName.SelectedIndex = 0;
        }
        public void load_server_name(ref string s)
        {
            //      SqlDataSourceEnumerator instance =
            //SqlDataSourceEnumerator.Instance;
            //      table = instance.GetDataSources();

            //      if (table.Rows.Count>0)
            //      {
            //          foreach (DataRow row in table.Rows)
            //          {
            //              if (row["InstanceName"].ToString() != null)
            //              {
            //                  s = row["ServerName"].ToString() + "\\" + row["InstanceName"].ToString();

            //              }
            //              else
            //              {
            //                  s = row["ServerName"].ToString();
            //              }
            //              cbo_servreName.Items.Add(s);
            //          }
            //      }
            //      else
            //          cbo_servreName.Items.Add(Environment.MachineName);
            //      s = cbo_servreName.Items[0].ToString();
            var registryViewArray = new[] { RegistryView.Registry32, RegistryView.Registry64 };
            s = string.Empty;
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
                            cbo_servreName.Items.Add(s);
                        }
                    }
                }
            }
            s = cbo_servreName.Items[0].ToString();
        }
        public void load_Database_CBO()
        {
            bll_serverName.cnn.Open();
            table = bll_serverName.cnn.GetSchema("Databases");
            cbbDatabaseName.Items.Clear();
            foreach (DataRow row in table.Rows)
            {
                cbbDatabaseName.Items.Add(row["database_name"]);
            }
            bll_serverName.cnn.Close();
        }

        private void cbo_servreName_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_Database_CBO();
        }
    }
}
