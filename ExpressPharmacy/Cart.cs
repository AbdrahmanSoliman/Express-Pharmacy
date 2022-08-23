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
    public partial class Cart : Form
    {
        SqlConnection sqlconnection = new SqlConnection(@"Data Source=XEONSTORE\SQLEXPRESS;Initial Catalog=pharma;Integrated Security=True");

        public Cart()
        {
            InitializeComponent();
            DisplayData();
        }

        private void plusBT_Click(object sender, EventArgs e)
        {
            int qnt = Convert.ToInt32(qntTB.Text);
            qnt++;
            qntTB.Text = qnt+"";
        }

        private void minusBT_Click(object sender, EventArgs e)
        {
            int qnt = Convert.ToInt32(qntTB.Text);
            if (qnt == 0)
                return;
            qnt--;
            qntTB.Text = qnt + "";
        }

        private void searchBt_Click(object sender, EventArgs e)
        {
            sqlconnection.Open();
            string query = "select pname,price,qnt from product where pname = '"+productTB.Text+"' ";
            SqlCommand sqlcommand = new SqlCommand(query, sqlconnection);
            sqlcommand.ExecuteNonQuery();
            DataTable db = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlcommand);
            dataAdapter.Fill(db);
            dataGridView1.DataSource = db;
            sqlconnection.Close();
        }

        void DisplayData()
        {
            sqlconnection.Open();
            string query = "select pname,price,qnt from product";
            SqlCommand sqlcommand = new SqlCommand(query, sqlconnection);
            sqlcommand.ExecuteNonQuery();
            DataTable db = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlcommand);
            dataAdapter.Fill(db);
            dataGridView1.DataSource = db;
            sqlconnection.Close();

        }

        private void Cart_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmaDataSet.product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.pharmaDataSet.product);

        }
        List<object> list = new List<object>();
        private void proceedBT_Click(object sender, EventArgs e)
        {
            try
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
                    if (availableqnt == 0)
                    {
                        MessageBox.Show(productTB.Text + " will be restocked soon.", "Out of Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        sqlconnection.Close();
                        return;
                    }
                    int buyingqnt = Convert.ToInt32(qntTB.Text);
                    if (buyingqnt > availableqnt)
                    {
                        MessageBox.Show("There is/are " + availableqnt + " only in stock", "In-Stock", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        sqlconnection.Close();
                        return;
                    }
                    int leftqnt = availableqnt - buyingqnt;
                    string queryproceed = "update product set qnt=" + leftqnt + " where pname= '" + productTB.Text + "' ";
                    SqlCommand sqlcommandproceed = new SqlCommand(queryproceed, sqlconnection);
                    sqlcommandproceed.ExecuteNonQuery();
                    string queryprice = "select price from product where pname = '" + productTB.Text + "' ";
                    SqlCommand sqlcommandprice = new SqlCommand(queryprice, sqlconnection);
                    SqlDataReader dataReaderPrice = sqlcommandprice.ExecuteReader();
                    double price = 0;
                    while (dataReaderPrice.Read())
                    {
                        int i = 0;
                        price = price + Convert.ToDouble(dataReaderPrice[i].ToString());
                        i++;
                    }
                    list.Add(price);
                    list.Add(price * buyingqnt);
                    Change(); //Another panel is visible and this one is invisible
                }
                else
                {
                    MessageBox.Show(" We don't sell " + productTB.Text + " in our pharmacy!", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                dataReaderProd.Close();
                sqlconnection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sqlconnection.Close();
            }
        }

        private void checkoutBTin_Click(object sender, EventArgs e)
        {
            if (fnameTBin.Text == "" || lnameTBin.Text == "" || phonenoTBin.Text == "")
            {
                MessageBox.Show("Please fill the form correctly for In-Store Pickup", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                int phone = Convert.ToInt32(phonenoTBin.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            sqlconnection.Open();
            string queryLast = "Select top 1 cust_id from customer order by cust_id desc";
            SqlCommand sqlcommandLast = new SqlCommand(queryLast, sqlconnection);
            SqlDataReader sqldataReaderLast = sqlcommandLast.ExecuteReader();
            int lastcustid = 0;
            while (sqldataReaderLast.Read() == true)
            {
                lastcustid = lastcustid + Convert.ToInt32(sqldataReaderLast[0].ToString());
            }
            sqlconnection.Close();
            sqlconnection.Open();
            lastcustid++;
            long phoneno = Convert.ToInt64(phonenoTBin.Text);
            string query = "insert into customer values('" + lastcustid + "','" + fnameTBin.Text + "','" + lnameTBin.Text + "', null , '" + phoneno + "')";
            SqlCommand sqlcommand = new SqlCommand(query, sqlconnection);
            sqlcommand.ExecuteNonQuery();
            int buyingqnt = Convert.ToInt32(qntTB.Text);
            MessageBox.Show("Customer Name: \t" + fnameTBin.Text + " " + lnameTBin.Text + "\nPhone no.: \t0" + phonenoTBin.Text + "\nCart item: \t" + productTB.Text + " \nPrice per box: \t" + list[0] + "\nQuantity: \t" + buyingqnt + "\nTotal Price: \t" + list[1] + "","Purchased Order",MessageBoxButtons.OK);
            Reset();
            sqlconnection.Close();
            DisplayData();
            Reverse();
        }

        public void Change()
        {
            this.label1.Visible = false;
            this.label2.Visible = false;
            this.minusBT.Visible = false;
            this.plusBT.Visible = false;
            this.proceedBT.Visible = false;
            this.productTB.Visible = false;
            this.searchBt.Visible = false;
            this.dataGridView1.Visible = false;
            this.qntTB.Visible = false;
            this.panel1.Visible = false;
            this.panel2.Visible = false;
            //The second panel
            this.panel10.Visible = true;
            this.label12.Visible = false;
            //this.panel3.Visible = true;
            //this.panel4.Visible = true;
            //this.panel5.Visible = true;
            //this.panel6.Visible = true;
            //this.panel7.Visible = true;
            //this.panel8.Visible = true;
            //this.panel9.Visible = true;
            //this.panel11.Visible = true;
            //this.panel12.Visible = true;

            //this.label3.Visible = true;
            //this.label4.Visible = true;
            //this.label5.Visible = true;
            //this.label6.Visible = true;
            //this.label7.Visible = true;
            //this.label8.Visible = true;
            //this.label9.Visible = true;
            //this.label10.Visible = true;
            //this.label11.Visible = true;

            //this.fnameTBin.Visible = true;
            //this.fnameTBout.Visible = true;
            //this.lnameTBin.Visible = true;
            //this.lnameTBout.Visible = true;
            //this.phonenoTBin.Visible = true;
            //this.phonenoTBout.Visible = true;
            //this.addressTB.Visible = true;

            this.checkoutBTin.Visible = true;
            this.checkoutBTout.Visible = true;

        }
        public void Reverse()
        {
            this.label1.Visible = true;
            this.label2.Visible = true;
            this.minusBT.Visible = true;
            this.plusBT.Visible = true;
            this.proceedBT.Visible = true;
            this.productTB.Visible = true;
            this.searchBt.Visible = true;
            this.dataGridView1.Visible = true;
            this.qntTB.Visible = true;
            this.panel1.Visible = true;
            this.panel2.Visible = true;

            this.panel10.Visible = false;
            this.checkoutBTin.Visible = false;
            this.checkoutBTout.Visible = false;
            this.label12.Visible = true;
        }
        public void Reset()
        {
            productTB.Text = "";
            qntTB.Text = "1";
            fnameTBin.Text = "";
            fnameTBout.Text = "";
            lnameTBin.Text = "";
            lnameTBout.Text = "";
            phonenoTBin.Text = "";
            phonenoTBout.Text = "";
            addressTB.Text = "";
        }

        private void checkoutBTout_Click(object sender, EventArgs e)
        {
            if (fnameTBout.Text == "" || lnameTBout.Text == "" || phonenoTBout.Text == "" || addressTB.Text == "")
            {
                MessageBox.Show("Please fill the form correctly for Delivery", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                int phone = Convert.ToInt32(phonenoTBout.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            sqlconnection.Open();
            string queryLast = "Select top 1 cust_id from customer order by cust_id desc";
            SqlCommand sqlcommandLast = new SqlCommand(queryLast, sqlconnection);
            SqlDataReader sqldataReaderLast = sqlcommandLast.ExecuteReader();
            int lastcustid = 0;
            while (sqldataReaderLast.Read() == true)
            {
                lastcustid = lastcustid + Convert.ToInt32(sqldataReaderLast[0].ToString());
            }
            sqlconnection.Close();
            sqlconnection.Open();
            lastcustid++;
            long phoneno = Convert.ToInt64(phonenoTBout.Text);
            string query = "insert into customer values('" + lastcustid + "','" + fnameTBout.Text + "','" + lnameTBout.Text + "', '"+addressTB.Text+"', '" + phoneno + "')";
            SqlCommand sqlcommand = new SqlCommand(query, sqlconnection);
            sqlcommand.ExecuteNonQuery();
            int buyingqnt = Convert.ToInt32(qntTB.Text);
            MessageBox.Show("Customer Name: \t" + fnameTBout.Text + " " + lnameTBout.Text + "\nPhone no.: \t0" + phonenoTBout.Text + "\nAddress: \t"+addressTB.Text+"\nCart item: \t" + productTB.Text + " \nPrice per box: \t" + list[0] + "\nQuantity: \t" + buyingqnt + "\nTotal Price: \t" + list[1] + "", "Purchased Order", MessageBoxButtons.OK);
            Reset();
            sqlconnection.Close();
            DisplayData();
            Reverse();
        }
    }
}
