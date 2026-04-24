using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IT_WFA_ADO
{
    public partial class Form2 : Form
    {
        private const string ConnectionString = "Data Source=MERT\\MSSQLSERVER01;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False;Command Timeout=30";

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            using SqlConnection con = new SqlConnection(ConnectionString);

            try
            {
                con.Open();
                string selectQuery = "Select * From Customers";
                SqlCommand cmd = new(selectQuery, con);
                using SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Customers c = new Customers(
                            reader["CustomerId"].ToString(),
                            reader["CompanyName"].ToString()

                        );
                    LbCustomers.Items.Add(c);

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Hata : {ex.Message}");
            }

            finally
            {
                con.Close();
            }
        }

        private void LbCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            using SqlConnection con = new SqlConnection(ConnectionString);

            if (LbCustomers.SelectedItem is not null)
            {
                Customers seciliCustomer = LbCustomers.SelectedItem as Customers;

                try
                {
                    con.Open();
                    string selectQuery = "Select * From Orders Where CustomerId = @CId";
                    SqlCommand cmd = new(selectQuery, con);
                    cmd.Parameters.AddWithValue("@CId", seciliCustomer.Id);
                    using SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Orders o = new Orders(
                            Convert.ToInt32(reader["OrderId"]),
                            Convert.ToDateTime(reader["OrderDate"])
                            );
                        LbOrders.Items.Add(o);

                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show($"Hata : {ex.Message}");
                }

                finally
                {
                    con.Close();
                }
            }
        }

        private void detaylToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LbOrders is not null)
            {
                Orders seciliSiparis = LbOrders.SelectedItem as Orders;
                Form3 form3 = new (seciliSiparis.Id);
                form3.ShowDialog();
            }
        }
    }
}
