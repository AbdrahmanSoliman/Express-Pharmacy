using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ExpressPharmacy
{
    public partial class Supply : Form
    {
        public Supply()
        {
            InitializeComponent();
        }
        SqlConnection sqlconnection = new SqlConnection(@"Data Source=XEONSTORE\SQLEXPRESS;Initial Catalog=pharma;Integrated Security=True");

        private void restockBT_Click(object sender, EventArgs e)
        {
            if (productTB.Text == "")
            {
                MessageBox.Show("Enter the name of product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                int qnt = Convert.ToInt32(qntTB.Text);
                if (qntTB.Text == "" || qnt < 1)
                {
                    MessageBox.Show("Enter a valid quantity!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            catch
            {
                MessageBox.Show("Enter a valid quantity!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            sqlconnection.Open();
            string queryprod = "select * from product where pname = '" + productTB.Text + "' ";
            SqlCommand sqlcommandprod = new SqlCommand(queryprod, sqlconnection);
            SqlDataReader dataReaderProd = sqlcommandprod.ExecuteReader();
            if (dataReaderProd.Read() == true)
            {
                dataReaderProd.Close();
                string queryqnt = "select qnt from product where pname = '" + productTB.Text + "' ";
                SqlCommand sqlcommandqnt = new SqlCommand(queryqnt, sqlconnection);
                SqlDataReader dataReaderQnt = sqlcommandqnt.ExecuteReader();
                int availableqnt = 0;
                while (dataReaderQnt.Read())
                {
                    int i = 0;
                    availableqnt = availableqnt + Convert.ToInt32(dataReaderQnt[i].ToString());
                    i++;
                }
                dataReaderQnt.Close();
                int supplyQnt = Convert.ToInt32(qntTB.Text);
                int allQnt = availableqnt + supplyQnt;

                string query = "update product set qnt ='" + allQnt + "' where pname = '" + productTB.Text + "'";
                SqlCommand sqlcommand = new SqlCommand(query, sqlconnection);
                sqlcommand.ExecuteNonQuery();
                MessageBox.Show(supplyQnt + " boxes of the medicine " + productTB.Text + " has/have been restocked\nCurrently In-Stock: \t '"+allQnt+"'", "Restocked Successfully", MessageBoxButtons.OK);
                Reset();
            }
            else
            {
                MessageBox.Show(" We don't sell " + productTB.Text + " in our pharmacy!", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dataReaderProd.Close();
            sqlconnection.Close();
        }
        public void Reset()
        {
            productTB.Text = "";
            qntTB.Text = "1";
            priceTB.Text = "";
            newProdTB.Text = "";
            newPriceTB.Text = "";
            newQntTB.Text = "1";
            catTB.Text = "1";
        }

        private void updateBT_Click(object sender, EventArgs e)
        {
            if (productTB.Text == "")
            {
                MessageBox.Show("Enter the name of product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                double price = Convert.ToDouble(priceTB.Text);
                if (qntTB.Text == "" || price < 1)
                {
                    MessageBox.Show("Enter a valid quantity!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Enter a reasonable price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            sqlconnection.Open();
            string queryprod = "select * from product where pname = '" + productTB.Text + "' ";
            SqlCommand sqlcommandprod = new SqlCommand(queryprod, sqlconnection);
            SqlDataReader dataReaderProd = sqlcommandprod.ExecuteReader();
            if (dataReaderProd.Read() == true)
            {
                dataReaderProd.Close();
                double prodPrice = Convert.ToDouble(priceTB.Text);
                string query = "update product set price=" + prodPrice + " where pname= '" + productTB.Text + "' ";
                SqlCommand sqlcommand = new SqlCommand(query, sqlconnection);
                sqlcommand.ExecuteNonQuery();
                MessageBox.Show("New price of "+productTB.Text+" = "+prodPrice+"", "Price Updated", MessageBoxButtons.OK);
                Reset();
            }
            else
            {
                MessageBox.Show(" We don't have such a " + productTB.Text + " in our pharmacy!", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dataReaderProd.Close();
            sqlconnection.Close();
        }

        private void supplyBt_Click(object sender, EventArgs e)
        {
            if (newProdTB.Text == "")
            {
                MessageBox.Show("Enter the name of product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                int qnt = Convert.ToInt32(newQntTB.Text);
                if (qntTB.Text == "" || qnt < 1)
                {
                    MessageBox.Show("Enter a valid quantity!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Enter a valid quantity!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                double price = Convert.ToDouble(newPriceTB.Text);
                if (qntTB.Text == "" || price < 1)
                {
                    MessageBox.Show("Enter a reasonable price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Enter a reasonable price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                int cat = Convert.ToInt32(catTB.Text);
                if (qntTB.Text == "" || cat < 0 || cat > 23)
                {
                    MessageBox.Show("Invalid category ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Invalid category ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            sqlconnection.Open();
            string queryLast = "Select top 1 p_id from product order by p_id desc";
            SqlCommand sqlcommandLast = new SqlCommand(queryLast, sqlconnection);
            SqlDataReader sqldataReaderLast = sqlcommandLast.ExecuteReader();
            int lastprodid = 0;
            while (sqldataReaderLast.Read() == true)
            {
                lastprodid = lastprodid + Convert.ToInt32(sqldataReaderLast[0].ToString());
            }
            sqldataReaderLast.Close();
            sqlconnection.Close();
            sqlconnection.Open();
            lastprodid++;
            int newQnt = Convert.ToInt32(newQntTB.Text);
            int newcatTB = Convert.ToInt32(catTB.Text);
            double newprice = Convert.ToDouble(newPriceTB.Text);
            string query = "insert into product values('"+lastprodid+"','"+newProdTB.Text+"','"+newprice+"','"+newQnt+"','"+newcatTB+"')";
            SqlCommand sqlcommand = new SqlCommand(query, sqlconnection);
            sqlcommand.ExecuteNonQuery();
            sqlconnection.Close();
            MessageBox.Show("" + productTB.Text + " product has been added to the pharmacy\nIts price = \t"+newprice+"\nWith Quantity : \t"+newQnt+"\nCategory : \t"+newcatTB+" ", "Product Added Successfully", MessageBoxButtons.OK,MessageBoxIcon.Information);
            Reset();
        }
    }
}
