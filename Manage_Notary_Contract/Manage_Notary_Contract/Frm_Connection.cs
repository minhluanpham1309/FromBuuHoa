using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manage_Notary_Contract
{
    public partial class Frm_Connection : Form
    {
        public Frm_Connection()
        {
            InitializeComponent();
        }

        Cl_Database db = new Cl_Database();
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
            // DESKTOP-24H985L\SQLEXPRESS

            BLL_ServerName bllSV = new BLL_ServerName();
            txtServerName.Text = bllSV.GetServerName();

            // Notary_Contract

            using (SqlConnection cnn = new SqlConnection("Server=" + bllSV.GetServerName() + ";integrated security=true"))
            {
                cnn.Open();
                DataTable dB = cnn.GetSchema("Databases");

                if (dB != null)
                {
                    foreach (DataRow _db in dB.Rows)
                    {
                        String dB_Name = _db.Field<String>("database_name");
                        //short dbID = _db.Field<short>("dbid");
                        cbbDatabaseName.Items.Add(dB_Name);
                    }
                }
            }
        }
    }
}
