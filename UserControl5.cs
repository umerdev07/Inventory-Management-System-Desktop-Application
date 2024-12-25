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

namespace IMS_FINAL
{
    public partial class UserControl5 : UserControl
    {
        public UserControl5()
        {
            InitializeComponent();
        }

        private void addpback_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserControl2 userControl2 = new UserControl2();
            userControl2.Show();
        }

        private void cleanProductbtn_Click(object sender, EventArgs e)
        {
            productName.Text = string.Empty;
            addCategoryName.Text = string.Empty;
            addUnitPrice.Text = string.Empty;
            addQuantityProduct.Text = string.Empty;

            productName.Focus();

        }


        private void addProductbtn_Click(object sender, EventArgs e)
        {
            // Retrieve values from the form fields
            // Retrieve values from the form fields
            string addProduct = productName.Text;
            string addCategory = addCategoryName.Text;

            // Validate Minimum Stock
            if (!int.TryParse(minstock.Text, out int minimumstock))
            {
                MessageBox.Show("Invalid Minimum Stock. Please enter a valid number.");
                return;
            }

            // Validate Unit Price
            if (!decimal.TryParse(addUnitPrice.Text, out decimal addUnit))
            {
                MessageBox.Show("Invalid Unit Price. Please enter a valid number.");
                return;
            }

            // Validate Quantity
            if (!int.TryParse(addQuantityProduct.Text, out int addQuantity))
            {
                MessageBox.Show("Invalid Quantity. Please enter a valid number.");
                return;
            }

            // Ensure productName and categoryName are not empty
            if (string.IsNullOrWhiteSpace(addProduct) || string.IsNullOrWhiteSpace(addCategory))
            {
                MessageBox.Show("Product name and category name cannot be empty.");
                return;
            }

            // Call the method to add the product to the database
            bool isSuccess = AddProductToDatabase(addProduct, addCategory, addUnit, addQuantity, minimumstock);

            if (isSuccess)
            {
                MessageBox.Show("Product added successfully!");
            }
            else
            {
                MessageBox.Show("Failed to add the product.");
            }

        }

        // Method to handle database interaction
        private bool AddProductToDatabase(string productName, string categoryName, decimal unitPrice, int quantity, int minstock)
        {
            string connectionString = @"Data Source=(localdb)\testLogin;Initial Catalog=IMS;Integrated Security=True";
            string query = "INSERT INTO Product (productName, categoryName, unitPrice, quantity, minimumStockLevel) " +
                           "VALUES (@productName, @categoryName, @unitPrice, @quantity, @minstock)";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Create SQL command and add parameters to prevent SQL injection
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@productName", productName);
                    command.Parameters.AddWithValue("@categoryName", categoryName);
                    command.Parameters.AddWithValue("@unitPrice", unitPrice);
                    command.Parameters.AddWithValue("@quantity", quantity);
                    command.Parameters.AddWithValue("@minstock", minstock); // Ensure this matches the query's parameter

                    // Open connection and execute the query
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    // Return true if product was added, otherwise false
                    return rowsAffected > 0;
                }
            }
            catch (SqlException sqlEx)
            {
                // Handle specific SQL errors
                MessageBox.Show($"SQL Error: {sqlEx.Message}\nStack Trace: {sqlEx.StackTrace}");
                return false;
            }
            catch (Exception ex)
            {
                // Handle any other general errors
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }
        }
    }
}

