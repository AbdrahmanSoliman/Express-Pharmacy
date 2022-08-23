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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }
        //SqlConnection sqlconnection = new SqlConnection(@"Data Source=XEONSTORE\SQLEXPRESS;Initial Catalog=pharma;Integrated Security=True");
        //Cart cart = new Cart();
        //private void checkoutBTin_Click(object sender, EventArgs e)
        //{
        //    bool isEmpty = !cart.list.Any();
        //    if (isEmpty)
        //    {
        //        MessageBox.Show("Empty");
        //        return;
        //    }

        //    if (fnameTBin.Text == "" || lnameTBin.Text == "" || phonenoTBin.Text == "")
        //    {
        //        MessageBox.Show("Please fill the form correctly for In-Store Pickup", "Information" , MessageBoxButtons.OK,MessageBoxIcon.Information);
        //        return;
        //    }
        //    try
        //    {
        //        int phone = Convert.ToInt32(phonenoTBin.Text);
        //    }
        //    catch(Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        return;
        //    }

        //    sqlconnection.Open();
        //    string queryLast = "Select top 1 cust_id from customer order by cust_id desc";
        //    SqlCommand sqlcommandLast = new SqlCommand(queryLast, sqlconnection);
        //    SqlDataReader sqldataReaderLast = sqlcommandLast.ExecuteReader();
        //    int lastcustid = 0;
        //    while(sqldataReaderLast.Read() == true)
        //    {
        //        lastcustid = lastcustid + Convert.ToInt32(sqldataReaderLast[0].ToString());
        //    }
        //    string query = "insert into customer values('"+(lastcustid++)+"','"+fnameTBin.Text+"','"+lnameTBin+"', null, '"+phonenoTBin+"')";
        //    MessageBox.Show("Customer Name: \t"+ fnameTBin.Text + " " + lnameTBin.Text + "\nPhone no.: \t0" + phonenoTBin.Text + "");
        //    //MessageBox.Show(cart.list[0]+ ""  + cart.list[1] + cart.list[2] + cart.list[3]);
        //    //MessageBox.Show(cart.list[0].ToString());
        //    MessageBox.Show("Cart item: \t'" + cart.list[0] + "' \nPrice per box: \t'" + cart.list[1] + "'\nQuantity: \t'" + cart.list[2] + "'\nTotal Price: \t'" + cart.list[3] + "'");

        //}
    }
}
