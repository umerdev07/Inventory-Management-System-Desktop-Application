using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace IMS_FINAL
{
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            string connectionString = @"Data Source=(localdb)\testLogin;Initial Catalog=IMS;Integrated Security=True";
            string query = "SELECT * FROM IMS.dbo.Product";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    productListGrid.DataSource = dataTable;
                    productListGrid.AutoResizeColumns();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {
            LoadData();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure the clicked cell is not a header
            {
                DataGridViewRow row = productListGrid.Rows[e.RowIndex];

                // Safely retrieve the values for Quantity and Price
                string quantityValue = row.Cells[4].Value?.ToString(); // Get Quantity as string
                string priceValue = row.Cells[3].Value?.ToString();    // Get Price as string

                // Try to parse Quantity (int)
                if (int.TryParse(quantityValue, out int quantity))
                {
                    quantitytxt.Text = quantity.ToString();
                }
                else
                {
                    quantitytxt.Text = "0"; // Default to 0 if parsing fails
                }

                // Try to parse Price (float)
                if (float.TryParse(priceValue, out float price))
                {
                    pricetxt.Text = price.ToString("F2"); // Format to 2 decimal places
                }
                else
                {
                    pricetxt.Text = "0.00"; // Default to 0.00 if parsing fails
                }
            }// Ensure the clicked cell is not a header and the row index is valid
            if (e.RowIndex >= 0)
            {
                // Get the clicked row
                DataGridViewRow row = productListGrid.Rows[e.RowIndex];

                // Safely retrieve the values for Quantity and Price
                string quantityValue = row.Cells[4].Value?.ToString(); // Assuming Quantity is in column 4
                string priceValue = row.Cells[3].Value?.ToString();    // Assuming Price is in column 3

                // Try to parse Quantity (int)
                if (int.TryParse(quantityValue, out int quantity))
                {
                    quantitytxt.Text = quantity.ToString(); // Display parsed quantity in the textbox
                }
                else
                {
                    quantitytxt.Text = "0"; // Default to 0 if parsing fails
                }

                // Try to parse Price (float)
                if (float.TryParse(priceValue, out float price))
                {
                    pricetxt.Text = price.ToString("F2"); // Display parsed price with 2 decimal places
                }
                else
                {
                    pricetxt.Text = "0.00"; // Default to 0.00 if parsing fails
                }
            }
        }



        private void iconButton1_Click(object sender, EventArgs e)
        {
            UserControl5 userControl5 = new UserControl5();
            Form1 f1 = new Form1();
            f1.Controls.Clear();
            userControl5.Dock = DockStyle.Fill;
            this.Controls.Add(userControl5);
            userControl5.BringToFront();
        }

        private void UserControl2_Load_1(object sender, EventArgs e)
        {
            LoadData();
        }
         
          
         
         
        private void updateProduct_Click(object sender, EventArgs e)
        { 
            if  (productListGrid.SelectedRows.Count > 0) // Ensure a row is selected
            { 
                 
                // Get the selected  row
                DataGridViewRow selectedRow = productListGrid.SelectedRows[0];
                 
                // Retrieve the pr oduct ID (assuming it's in the first column, index 0)
                int productId = Convert.ToInt32(selectedRow.Cells[0].Value);
                 
                // Ge t the updated Quantity and Price from the textboxes
                if ( int.TryParse(quantitytxt.Text, out int updatedQuantity) &&
                     float.TryParse(pricetxt.Text, out float updatedPrice))
                {  
                    // Ensure p rice has 2 decimal places
                    updatedPrice = (float)Math.Round(updatedPrice, 2);

                    string connectionString = @"Data Source=(localdb)\testLogin;Initial Catalog=IMS;Integrated Security=True";
                    string updateQuery = "UPDATE IMS.dbo.Product SET quantity = @quantity, unitPrice = @price WHERE ProductID  = @id";

                    try
                    {
                        using (SqlConnection con = new SqlConnection(connectionString))
                        {
                            con.Open();
                            using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                            {
                                // Add parameters to prevent SQL injection
                                cmd.Parameters.AddWithValue("@quantity", updatedQuantity);
                                cmd.Parameters.AddWithValue("@price", updatedPrice);
                                cmd.Parameters.AddWithValue("@id", productId);

                                // Execute the query
                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Product updated successfully!");

                                    // Refresh the DataGridView to reflect changes
                                    LoadData();
                                }
                                else
                                {
                                    MessageBox.Show("Failed to update the product.");
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter valid values for Quantity and Price.");
                }
            }
            else
            {
                MessageBox.Show("Please select a product to update.");
            }
        }

        private void deleteProduct_Click(object sender, EventArgs e)
        {
            if (productListGrid.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = productListGrid.SelectedRows[0];

                // Retrieve the product ID (assuming it's in the first column, index 0)
                int productId = Convert.ToInt32(selectedRow.Cells[0].Value);

                string connectionString = @"Data Source=(localdb)\testLogin;Initial Catalog=IMS;Integrated Security=True";
                string deleteQuery = "DELETE FROM IMS.dbo.Product WHERE ProductID = @id";

                try
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        using (SqlCommand cmd = new SqlCommand(deleteQuery, con))
                        {
                            // Add parameter to prevent SQL injection
                            cmd.Parameters.AddWithValue("@id", productId);

                            // Execute the query
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Product deleted successfully!");

                                // Refresh the DataGridView to reflect changes
                                LoadData();
                            }
                            else
                            {
                                MessageBox.Show("Failed to delete the product.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a product to delete.");
            }
        }

        private void searchProduct_TextChanged(object sender, EventArgs e)
        {
            FilterData();
        }
        private void FilterData()
        {
            string category = searchProduct.Text.Trim();  // Get the category text

            // Build the SQL query to filter by category
            string connectionString = @"Data Source=(localdb)\testLogin;Initial Catalog=IMS;Integrated Security=True";
            string query = "SELECT * FROM IMS.dbo.Product WHERE 1=1";  // Base query to fetch all data

            // Add category filter to the query if a category is provided
            if (!string.IsNullOrEmpty(category))
            {
                query += " AND categoryName LIKE @category";  // Filter by category
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Add parameter for category to prevent SQL injection
                        if (!string.IsNullOrEmpty(category))
                        {
                            cmd.Parameters.AddWithValue("@category", "%" + category + "%"); // Use LIKE for partial matching
                        }

                        // Execute the query and fill the DataGridView
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        productListGrid.DataSource = dataTable;
                        productListGrid.AutoResizeColumns();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while filtering: " + ex.Message);
            }
        }

        private void viewAllProducts_Click(object sender, EventArgs e)
        {
            LoadData();
            searchProduct.Text = string.Empty;
            quantitytxt.Text = String.Empty;
            pricetxt.Text = String.Empty;
        }
    }
}
