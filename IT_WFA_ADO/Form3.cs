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
    public partial class Form3 : Form
    {
        private const string ConnectionString = "Data Source=MERT\\MSSQLSERVER01;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False;Command Timeout=30";
        private readonly int _orderID;
        public Form3(int orderId)
        {
            _orderID = orderId;
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            DgvOrderDetail.ColumnCount = 4;
            DgvOrderDetail.Columns[0].Name = "Name";
            DgvOrderDetail.Columns[1].Name = "Price";
            DgvOrderDetail.Columns[2].Name = "Quantity";
            DgvOrderDetail.Columns[3].Name = "Discount";

            using SqlConnection con = new SqlConnection(ConnectionString);

            try
            {
                con.Open();
                string selectQuery = "Select p.ProductName, od.UnitPrice, od.Quantity, od.Discount From [Order Details] od Join Products p On od.ProductId = p.ProductId Where OrderId = @CId";
                SqlCommand cmd = new(selectQuery, con);
                cmd.Parameters.AddWithValue("@CId", _orderID);
                using SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    OrderDetails o = new OrderDetails(
                        reader["ProductName"].ToString(),
                        Convert.ToDecimal(reader["UnitPrice"]),
                        Convert.ToInt16(reader["Quantity"]),
                        Convert.ToDecimal(reader["Discount"])
                    );
                    DgvOrderDetail.Rows.Add(o,ProductName, o.Price, o.Quantity, o.Discount);
                }
            }

            catch (SqlException ex)
            {
                MessageBox.Show($"Hata : {ex.Message}");
            }

            finally
            {
                con.Close();
            }
        }
    }
}
