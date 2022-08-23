using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpressPharmacy
{
    public partial class EmployeeHome : Form
    {
        public EmployeeHome()
        {
            InitializeComponent();
        }
        ToolbarControl tC = new ToolbarControl();

        private void exitBt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ToolbarControl(object sender, MouseEventArgs e)
        {
            tC.toolbarControl(this.Handle);
        }

        private void SideToolbarControl(object sender, MouseEventArgs e)
        {
            tC.toolbarControl(this.Handle);
        }

        public void Change(object item)
        {
            if (this.HomeImage.Controls.Count > 0)
            {
                this.HomeImage.Controls.RemoveAt(0);
                Form form = item as Form;
                form.TopLevel = false;
                form.Dock = DockStyle.Fill;
                this.HomeImage.Controls.Add(form);
                this.HomeImage.Tag = form;
                form.Show();
            }
            else
            {

                Form form = item as Form;
                form.TopLevel = false;
                form.Dock = DockStyle.Fill;
                this.HomeImage.Controls.Add(form);
                this.HomeImage.Tag = form;
                form.Show();
            }

        }

        private void cartIconBt_Click(object sender, EventArgs e)
        {
            Change(new Cart());
        }

        private void expiredIconBt_Click(object sender, EventArgs e)
        {
            Change(new Expired());
        }

        private void supplyIconBt_Click(object sender, EventArgs e)
        {
            Change(new Supply());
        }

        private void logoutBt_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
    }
}
