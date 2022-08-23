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
    public partial class Expired : Form
    {
        public Expired()
        {
            InitializeComponent();
            DisplayData();
        }

        SqlConnection sqlconnection = new SqlConnection(@"Data Source=XEONSTORE\SQLEXPRESS;Initial Catalog=pharma;Integrated Security=True");
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

        private void removeQnt_Click(object sender, EventArgs e)
        {
            if(productTB.Text == "")
            {
                MessageBox.Show("Enter the name of the expired product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show(" There is no available quantity of " + productTB.Text + " to be expired!", "Out of Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    sqlconnection.Close();
                    return;
                }
                int qntExpired = Convert.ToInt32(qntTB.Text);
                if (qntExpired > availableqnt)
                {
                    MessageBox.Show("There is/are " + availableqnt + " only in stock\nRe-enter a valid quantity", "In-Stock", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    sqlconnection.Close();
                    return;
                }
                int leftqnt = availableqnt - qntExpired;
                string queryproceed = "update product set qnt=" + leftqnt + " where pname= '" + productTB.Text + "' ";
                SqlCommand sqlcommandproceed = new SqlCommand(queryproceed, sqlconnection);
                sqlcommandproceed.ExecuteNonQuery();
                sqlconnection.Close();
                DisplayData();
                MessageBox.Show("The expired medicine boxes of "+productTB.Text+" have been dispatched\nExpired boxes: \t"+qntTB.Text+"\nCurrently In-Stock:    "+leftqnt+"", "Task Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                productTB.Text = "";
                qntTB.Text = "1";
            }
            else
            {
                MessageBox.Show(" We don't have such a " + productTB.Text + " in our pharmacy!", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dataReaderProd.Close();
            sqlconnection.Close();
        }

        private void removeAllBT_Click(object sender, EventArgs e)
        {
            if (productTB.Text == "")
            {
                MessageBox.Show("Enter the name of the expired product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            sqlconnection.Open();
            string queryprod = "select * from product where pname = '" + productTB.Text + "' ";
            SqlCommand sqlcommandprod = new SqlCommand(queryprod, sqlconnection);
            SqlDataReader dataReaderProd = sqlcommandprod.ExecuteReader();
            if (dataReaderProd.Read() == true)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure that all the boxes of " + productTB.Text + " are expired ?", "Requires Action", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
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
                        MessageBox.Show(" There is no available quantity of "+productTB.Text+" to be expired!", "Out of Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        sqlconnection.Close();
                        return;
                    }

                    string queryproceed = "update product set qnt=" + 0 + " where pname= '" + productTB.Text + "' ";
                    SqlCommand sqlcommandproceed = new SqlCommand(queryproceed, sqlconnection);
                    sqlcommandproceed.ExecuteNonQuery();
                    sqlconnection.Close();
                    DisplayData();
                    MessageBox.Show("All expired medicine boxes of " + productTB.Text + " have been dispatched\nCurrently In-Stock:  0", "Task Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    productTB.Text = "";
                    qntTB.Text = "1";
                }
            }
            else
            {
                MessageBox.Show(" We don't have such a " + productTB.Text + " in our pharmacy!", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dataReaderProd.Close();
            sqlconnection.Close();
        }
    }
}
