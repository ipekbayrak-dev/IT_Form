using Microsoft.Data.SqlClient;

namespace IT_WFA_ADO
{
    public partial class Form1 : Form
    {
        private const string ConnectionString = "Data Source=MERT\\MSSQLSERVER01;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False;Command Timeout=30";
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnGetCategories_Click(object sender, EventArgs e)
        {
            using SqlConnection sqlConnection = new(ConnectionString);

            try
            {
                sqlConnection.Open();
                string selectQuery = "Select * From Categories";
                SqlCommand cmd = new(selectQuery, sqlConnection);
                using SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Category c = new Category(
                            Convert.ToInt32(reader["CustomerId"]),
                            reader["CompanyName"].ToString()

                        );
                    LbCategories.Items.Add(c);

                }

            }

            catch (Exception ex)
            {
                MessageBox.Show($"Hata : {ex.Message}");
            }

            finally
            {
                sqlConnection.Close();
            }
        }

        private void LbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LbCategories.SelectedItems is not null)
            {
                LbProducts.Items.Clear();

                Category seciliKategori = LbCategories.SelectedItem as Category;

                using SqlConnection sqlConnection = new(ConnectionString);

                try
                {
                    sqlConnection.Open();
                    string selectQuery = "Select * From Products Where CategoryId = @CId";
                    SqlCommand cmd = new(selectQuery, sqlConnection);
                    cmd.Parameters.AddWithValue("@CId", seciliKategori.Id);
                    using SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Products p = new(
                                Convert.ToInt32(reader["ProductId"]),
                                reader["ProductName"].ToString()!,
                                Convert.ToDecimal(reader["UnitPrice"])
                            );
                        LbProducts.Items.Add(p);

                    }

                }

                catch (SqlException ex)
                {
                    MessageBox.Show($"Hata : {ex.Message}");
                }

                finally
                {
                    sqlConnection.Close();
                }
            }
        }
    }
}
