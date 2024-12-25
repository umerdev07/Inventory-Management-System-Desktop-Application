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
using System.Windows.Markup;
using System.Xml.Linq;

namespace IMS_FINAL
{
    public partial class UserControl3 : UserControl
    {
        private SqlConnection connection = new SqlConnection("Data Source=(localdb)\\testLogin;Integrated Security=True");
        private billgenerate billgenerate = new billgenerate();
        public UserControl3()
        {
            InitializeComponent();
            billgenerate.Hide();
        }

        private void ClearControl()
        {
            categorycmdBox.Items.Clear();
            productcmdBox.Items.Clear();
            unitPriceBox.Clear();
            quantityBox.Clear();
        }

        private void UserControl3_Load(object sender, EventArgs e)
        {
            ClearControl();

            LoadCategories();
        }


        private void LoadCategories()
        {

            try
            {
                connection.Open();
                string query = "SELECT Distinct categoryName FROM IMS.dbo.Product";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                categorycmdBox.Items.Clear(); // Clear existing items
                while (reader.Read())
                {
                    string category = reader["categoryName"].ToString().Trim(); // Ensure no whitespace issues
                    if (!string.IsNullOrEmpty(category))
                    {
                        categorycmdBox.Items.Add(category);
                    }
                }
                reader.Close();

                if (categorycmdBox.Items.Count > 0)
                {
                    categorycmdBox.SelectedIndex = 0; // Automatically select the first category
                }
                else
                {
                    MessageBox.Show("No categories found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading categories: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }

        private void productcmdBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                if (productcmdBox.SelectedItem != null)
                {
                    string selectedProduct = productcmdBox.SelectedItem.ToString();
                    FetchUnitPrice(selectedProduct);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching unit price: {ex.Message}");
            }
        }

        private void FetchUnitPrice(string productNames)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=(localdb)\\testLogin;Integrated Security=True"))
                {
                    connection.Open();
                    string query = "SELECT unitPrice FROM IMS.dbo.Product WHERE productName = @productName";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add("@productName", System.Data.SqlDbType.NVarChar).Value = productNames;

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                unitPriceBox.Text = reader["unitPrice"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("No unit price found for the selected product.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching unit price: {ex.Message}");
            }
        }

        private void categorycmdBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (categorycmdBox.SelectedItem != null)
            {
                LoadProductsByCategory(categorycmdBox.SelectedItem.ToString());
            }

        }

        private void LoadProductsByCategory(string category)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=(localdb)\\testLogin;Integrated Security=True"))
                {
                    connection.Open();
                    string query = "SELECT productName FROM IMS.dbo.Product WHERE categoryName = @categoryName";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add("@categoryName", System.Data.SqlDbType.NVarChar).Value = category;

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            productcmdBox.Items.Clear();    // Clear existing items

                            while (reader.Read())
                            {
                                string product = reader["productName"].ToString().Trim();
                                if (!string.IsNullOrEmpty(product))
                                {
                                    productcmdBox.Items.Add(product);
                                }
                            }

                            if (productcmdBox.Items.Count > 0)
                            {
                                productcmdBox.SelectedIndex = 0; // Automatically select the first product
                            }
                            else
                            {
                                MessageBox.Show("No products found for this category.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading products: {ex.Message}");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void quantityBox_TextChanged(object sender, EventArgs e)
        {
            // Check if the input is a valid number
            if (int.TryParse(quantityBox.Text, out int quantity) && float.TryParse(unitPriceBox.Text, out float unitPrice))
            {
                if (quantity > 0)
                {
                    // Calculate the total price
                    float totalPriceValue = unitPrice * quantity;
                    totalPrice.Text = totalPriceValue.ToString("F2");
                }
                else
                {
                    totalPrice.Text = "0.00"; // If quantity is not greater than 0
                }
            }
            else
            {
                totalPrice.Text = "0.00"; // Handle invalid input
            }
        }

        private void addToCart_Click(object sender, EventArgs e)
        {
            try
            {
                if (categorycmdBox.SelectedItem != null && productcmdBox.SelectedItem != null &&
                    float.TryParse(unitPriceBox.Text, out float unitPrice) &&
                    int.TryParse(quantityBox.Text, out int quantity) && quantity > 0)
                {
                    string category = categorycmdBox.SelectedItem.ToString();
                    string product = productcmdBox.SelectedItem.ToString();
                    float totalPriceValue = unitPrice * quantity;

                    using (SqlConnection connection = new SqlConnection("Data Source=(localdb)\\testLogin;Integrated Security=True"))
                    {
                        connection.Open();

                        // Start a transaction
                        using (SqlTransaction transaction = connection.BeginTransaction())
                        {
                            try
                            {
                                // Check available stock
                                string stockQuery = @"
                        SELECT quantity, MinimumStockLevel 
                        FROM IMS.dbo.Product 
                        WHERE productName = @Product AND categoryName = @Category;";
                                int availableStock = 0;
                                int minimumStock = 0;

                                using (SqlCommand stockCommand = new SqlCommand(stockQuery, connection, transaction))
                                {
                                    stockCommand.Parameters.AddWithValue("@Product", product);
                                    stockCommand.Parameters.AddWithValue("@Category", category);

                                    using (SqlDataReader reader = stockCommand.ExecuteReader())
                                    {
                                        if (reader.Read())
                                        {
                                            availableStock = reader.GetInt32(0);
                                            minimumStock = reader.GetInt32(1);
                                        }
                                        else
                                        {
                                            throw new Exception("Product not found.");
                                        }
                                    }
                                }

                                // Validate stock
                                if (availableStock < quantity)
                                {
                                    throw new Exception($"Insufficient stock. Available stock: {availableStock}, requested quantity: {quantity}.");
                                }

                                // Insert data into the Sales table
                                string insertQuery = @"
                        INSERT INTO IMS.dbo.Sales (Product, Category, UnitPrice, Quantity, TotalPrice) 
                        VALUES (@Product, @Category, @UnitPrice, @Quantity, @TotalPrice)";
                                using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection, transaction))
                                {
                                    insertCommand.Parameters.AddWithValue("@Product", product);
                                    insertCommand.Parameters.AddWithValue("@Category", category);
                                    insertCommand.Parameters.AddWithValue("@UnitPrice", unitPrice);
                                    insertCommand.Parameters.AddWithValue("@Quantity", quantity);
                                    insertCommand.Parameters.AddWithValue("@TotalPrice", totalPriceValue);

                                    insertCommand.ExecuteNonQuery();
                                }

                                // Update the product quantity in the Product table
                                string updateQuery = @"
                        UPDATE IMS.dbo.Product 
                        SET quantity = quantity - @Quantity 
                        WHERE productName = @Product AND categoryName = @Category;";
                                using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection, transaction))
                                {
                                    updateCommand.Parameters.AddWithValue("@Quantity", quantity);
                                    updateCommand.Parameters.AddWithValue("@Product", product);
                                    updateCommand.Parameters.AddWithValue("@Category", category);

                                    updateCommand.ExecuteNonQuery();
                                }

                                // Commit the transaction
                                transaction.Commit();

                                // Check if remaining stock is below the minimum stock level
                                int remainingStock = availableStock - quantity;
                                if (remainingStock < minimumStock)
                                {
                                    MessageBox.Show($"Warning: Stock for {product} is below the minimum threshold!");
                                }
                                else
                                {
                                    MessageBox.Show("Item added to cart and stock updated successfully!");
                                }

                                // Refresh the DataGridView
                                LoadSalesData();
                            }
                            catch (Exception ex)
                            {
                                // Rollback the transaction in case of an error
                                transaction.Rollback();
                                MessageBox.Show($"Transaction failed: {ex.Message}");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please ensure all fields are filled out correctly.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding to cart: {ex.Message}");
            }
        }




        private void LoadSalesData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=(localdb)\\testLogin;Integrated Security=True"))
                {
                    connection.Open();

                    // Retrieve data from the Sales table
                    string query = "SELECT * FROM IMS.dbo.Sales";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable salesData = new DataTable();
                        adapter.Fill(salesData);

                        // Bind the data to the DataGridView
                        salesDataGrid.DataSource = salesData;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading sales data: {ex.Message}");
            }
        }

        private void removeProduct_Click(object sender, EventArgs e)
        {

            if (salesDataGrid.SelectedRows.Count > 0)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection("Data Source=(localdb)\\testLogin;Integrated Security=True"))
                    {
                        connection.Open();

                        // Start a transaction
                        using (SqlTransaction transaction = connection.BeginTransaction())
                        {
                            try
                            {
                                DataGridViewRow selectedRow = salesDataGrid.SelectedRows[0];
                                string product = selectedRow.Cells["Product"].Value.ToString();
                                string category = selectedRow.Cells["Category"].Value.ToString();
                                int quantity = int.Parse(selectedRow.Cells["Quantity"].Value.ToString());

                                // Delete the sale from the Sales table
                                string deleteQuery = @"
                        DELETE FROM IMS.dbo.Sales 
                        WHERE SalesID = @SaleID";
                                using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection, transaction))
                                {
                                    deleteCommand.Parameters.AddWithValue("@SaleID", selectedRow.Cells["SalesID"].Value);
                                    deleteCommand.ExecuteNonQuery();
                                }

                                // Update the product quantity in the Product table
                                string updateQuery = @"
                        UPDATE IMS.dbo.Product 
                        SET quantity = quantity + @Quantity 
                        WHERE productName = @Product AND categoryName = @Category";
                                using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection, transaction))
                                {
                                    updateCommand.Parameters.AddWithValue("@Quantity", quantity);
                                    updateCommand.Parameters.AddWithValue("@Product", product);
                                    updateCommand.Parameters.AddWithValue("@Category", category);
                                    updateCommand.ExecuteNonQuery();
                                }

                                // Commit the transaction
                                transaction.Commit();
                                MessageBox.Show("Sale deleted and stock updated successfully!");

                                // Refresh the DataGridView
                                LoadSalesData(); // Assuming this function refreshes the DataGridView
                            }
                            catch (Exception ex)
                            {
                                // Rollback the transaction in case of an error
                                transaction.Rollback();
                                MessageBox.Show($"Transaction failed: {ex.Message}");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting sale: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Please select a row from the DataGridView.");
            }



        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            // Get the customer name and number
            string custName = custnam.Text.Trim(); // Use Trim to remove any leading or trailing spaces
            string custNumbers = custno.Text.Trim(); // Corrected to use the appropriate TextBox for customer number
            string TotalPrice = totalPrice.Text.Trim();

            // Validate customer name and number
            if (string.IsNullOrEmpty(custName) || string.IsNullOrEmpty(custNumbers))
            {
                MessageBox.Show("Please enter the customer name and contact number before generating the bill.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if there are any products in the sales list
            if (salesDataGrid.Rows.Count == 0) // salesDataGrid.Rows.Count < 0 is unnecessary
            {
                MessageBox.Show("No products in the sales list. Please add a product before generating the bill.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Stop further execution
            }

            decimal totalAmount = 0;
            foreach (DataGridViewRow row in salesDataGrid.Rows)
            {
                if (row.Cells["TotalPrice"] != null && row.Cells["TotalPrice"].Value != DBNull.Value)
                {
                    totalAmount += Convert.ToDecimal(row.Cells["TotalPrice"].Value); // Add UnitPrice value to totalAmount
                }
            }

            // Display the total amount in your totalPrice field (assuming it's a TextBox or Label)
            totalPrice.Text = totalAmount.ToString("C2");

            // Proceed with bill generation
            try
            {
                // Create a new bill generation instance and pass the customer details
                billgenerate billGenerateControl = new billgenerate
                {
                    customerNames = custName,
                    customerNumbers = custNumbers,
                    salesData = salesDataGrid,
                    TOTALPRICE = totalAmount.ToString()

                };

                // Clear the current form and load the bill generation control
                this.Controls.Clear(); // Clear the current UserControl
                billGenerateControl.Dock = DockStyle.Fill; // Make the new UserControl fill the parent container
                this.Controls.Add(billGenerateControl); // Add the bill generation UserControl
                billGenerateControl.BringToFront(); // Bring it to the front
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while generating the bill: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearcart_Click(object sender, EventArgs e)
        {
            // Step 1: Optionally clear the total price display in the UI
            totalPrice.Text = string.Empty; // or set to "0.00" or a default value

            // Step 2: Show a confirmation message for clearing the cart in the UI
            MessageBox.Show("The cart has been cleared.", "Cart Cleared", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Step 3: Clear Data from Database (Only deleting from Sales table)
            try
            {
                // Ensure you have a valid connection string
                string connectionString = "Data Source=(localdb)\\testLogin;Integrated Security=True";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Step 4: Delete all records from the Sales table
                    string query = "DELETE FROM IMS.dbo.Sales"; // Ensure 'Sales' is your correct table name
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Check if any rows were affected
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("The cart has been cleared from the database.", "Database Cleared", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No records found to delete in the database.", "No Data Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                // Handle SQL exceptions (e.g., connection issues, query issues)
                MessageBox.Show($"SQL error occurred: {sqlEx.Message}", "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Handle general exceptions
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}    