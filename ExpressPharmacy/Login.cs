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

namespace ExpressPharmacy
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection sqlconnection = new SqlConnection(@"Data Source=XEONSTORE\SQLEXPRESS;Initial Catalog=pharma;Integrated Security=True");

        ToolbarControl tC = new ToolbarControl();

        private void ToolbarControl(object sender, MouseEventArgs e)
        {
            tC.toolbarControl(this.Handle);
        }

        private void loginBT_Click(object sender, EventArgs e)
        {
            try
            {
                if (loginTB.Text == "" || passTB.Text == "")
                {
                    MessageBox.Show("Please enter your email/password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {
                long pass = Convert.ToInt64(passTB.Text);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                long password = Convert.ToInt64(passTB.Text);
                sqlconnection.Open();
                string query = "select * from emp where email = '" + loginTB.Text + "' and pass = '" + password + "'";
                SqlCommand sqlcmd = new SqlCommand(query, sqlconnection);
                SqlDataReader dataReader = sqlcmd.ExecuteReader(); // true or false

                if (dataReader.Read() == true)
                {
                    dataReader.Close();
                    //string admin = "select * from emp where email = '" + loginTB.Text + "' and pass = '" + passTB.Text + "' ";
                    //SqlCommand sqlcmdcheck = new SqlCommand(admin, sqlconnection);
                    //SqlDataReader dataReaderCheck = sqlcmd.ExecuteReader();
                    //dataReaderCheck.Close();
                    this.Hide();
                    EmployeeHome h = new EmployeeHome();
                    h.Show();
                }
                else
                {
                    MessageBox.Show("Please Try Again", "Wrong Email/Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sqlconnection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sqlconnection.Close();
            }
        }

        private void exitBt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
