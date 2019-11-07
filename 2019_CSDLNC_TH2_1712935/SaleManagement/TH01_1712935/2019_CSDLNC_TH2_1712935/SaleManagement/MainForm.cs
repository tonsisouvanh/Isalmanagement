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

namespace SaleManagement
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //****************TRY*****************//
            if(txtbUsername.Text == string.Empty || txtbPassword.Text == string.Empty)
            {
                MessageBox.Show("Please enter username or password first");
                return;
            }

            string username = txtbUsername.Text.ToString();
            string password = txtbPassword.Text.ToString();
            if (username == "admin" &&  password == "admin")
            {
                this.Hide();
                SalesOrderHeaderForm f = new SalesOrderHeaderForm();
                f.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Username or password is invalid");
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
