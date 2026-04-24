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
    public partial class Form4 : Form
    {
        private const string ConnectionString = "Data Source=MERT\\MSSQLSERVER01;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False;Command Timeout=30";
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            ShipperList();
        }

        private void ShipperList()
        {
            DgvShippers.Rows.Clear();
            DgvShippers.ColumnCount = 3;
            DgvShippers.Columns[0].Name = "ID";
            DgvShippers.Columns[1].Name = "CompanyName";
            DgvShippers.Columns[2].Name = "Phone";

            using SqlConnection con = new SqlConnection(ConnectionString);

            try
            {
                con.Open();
                string selectQuery = "Select * From Shippers";
                SqlCommand cmd = new(selectQuery, con);
                using SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    DgvShippers.Rows.Add(reader[0], reader[1], reader[2]);
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

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            if (BtnEkle.Text == "Güncelle")
                UpdateShipper();
            else
                AddShipper();
        }

        private void AddShipper()
        {
            using SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            string insertQuery = "Insert Into Shippers Values(@CName, @Phone)";
            using SqlCommand sqlCommand = new(insertQuery, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@CName", TbCompanyName.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@Phone", MtbPhone.Text);

            try
            {
                sqlConnection.Open();
                int rowsAffected = sqlCommand.ExecuteNonQuery();

                if (rowsAffected < 1)
                {
                    MessageBox.Show("Ekleme işlemi sırasında bir hata ile karşılaşıldı.");
                }

                ShipperList();
                TbCompanyName.Text = MtbPhone.Text = string.Empty;
                TbCompanyName.Focus();
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        private void UpdateShipper()
        {
            using SqlConnection conn = new SqlConnection(ConnectionString);
            string updateQuery = "Update Shippers Set CompanyName = @CName, Phone = @Phone Where ShipperId = @SId";
            using SqlCommand cmd = new(updateQuery, conn);
            cmd.Parameters.AddWithValue("@CName", TbCompanyName.Text.Trim());
            cmd.Parameters.AddWithValue("@Phone", MtbPhone.Text);
            cmd.Parameters.AddWithValue("@SId", shipperId);

            try
            {
                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected < 1)
                {
                    MessageBox.Show("Güncelleme işlemi sırasında bir hata ile karşılaşıldı.");
                }

                ShipperList();
                TbId.Text = TbCompanyName.Text = MtbPhone.Text = string.Empty;
                shipperId = 0;
                BtnEkle.Text = "Ekle";
                TbCompanyName.Focus();
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }
            finally
            {
                conn.Close();
            }
        }

        private void TsmiUpdate_Click(object sender, EventArgs e)
        {
            if (shipperId == 0) return;

            using SqlConnection conn = new SqlConnection(ConnectionString);
            string query = "Select * From Shippers Where ShipperId = @SId";
            using SqlCommand cmd = new(query, conn);
            cmd.Parameters.AddWithValue("@SId", shipperId);

            try
            {
                conn.Open();
                using SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    TbId.Text = reader["ShipperId"].ToString();
                    TbCompanyName.Text = reader["CompanyName"].ToString();
                    MtbPhone.Text = reader["Phone"].ToString();
                }

                BtnEkle.Text = "Güncelle";
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }
            finally
            {
                conn.Close();
            }
        }

        private void TsmiDelete_Click(object sender, EventArgs e)
        {
            using SqlConnection conn = new SqlConnection(ConnectionString);

            if (shipperId != 0)
            {
                string query = "Delete From Shippers Where ShipperId = @SId";
                using SqlCommand cmd = new(query, conn);
                cmd.Parameters.AddWithValue("@SId", shipperId);

                try
                {
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected < 0)
                    {
                        MessageBox.Show("Silme işlemi sırasında hata ile karşılaşıldı");

                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Hata: {ex.Message}");
                }
                finally
                {
                    conn.Close();
                }

            }
            ShipperList();
        }

        int shipperId = 0;
        private void DgvShippers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                DataGridViewRow row = DgvShippers.Rows[e.RowIndex];

                shipperId = Convert.ToInt32(row.Cells["ID"].Value);
            }
        }
    }
}
