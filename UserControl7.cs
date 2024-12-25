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
    public partial class UserControl7 : UserControl
    {
        public UserControl7()
        {
            InitializeComponent();

        }



        private void LoadUsersData(string searchTerm = "")
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=(localdb)\\testLogin;Integrated Security=True"))
                {
                    connection.Open();

                    string selectQuery = "SELECT * FROM IMS.dbo.Users";

                    // If a search term is provided, filter the results
                    if (!string.IsNullOrEmpty(searchTerm))
                    {
                        selectQuery += " WHERE Username LIKE @SearchTerm";
                    }

                    using (SqlCommand selectCommand = new SqlCommand(selectQuery, connection))
                    {
                        if (!string.IsNullOrEmpty(searchTerm))
                        {
                            selectCommand.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");
                        }

                        using (SqlDataReader reader = selectCommand.ExecuteReader())
                        {
                            DataTable dataTable = new DataTable();
                            dataTable.Load(reader);

                            UserDataGrid.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading users: {ex.Message}");
            }
        }


        private void DeleteUserFromDatabase(int userId)
        {
            try
            {
                // Replace with your database connection string
                string connectionString = "Data Source=(localdb)\\testLogin;Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL query to delete the user by ID
                    string query = "DELETE FROM Users WHERE ID = @userId";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameter to the query
                        command.Parameters.AddWithValue("@userId", userId);

                        // Execute the query
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            LoadUsersData(textBox1.Text);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            if (UserDataGrid.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = UserDataGrid.SelectedRows[0];

                // Retrieve the product ID (assuming it's in the first column, index 0)
                int userID = Convert.ToInt32(selectedRow.Cells[0].Value);

                string connectionString = @"Data Source=(localdb)\testLogin;Initial Catalog=IMS;Integrated Security=True";
                string deleteQuery = "DELETE FROM IMS.dbo.Users WHERE ID = @id";

                try
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        using (SqlCommand cmd = new SqlCommand(deleteQuery, con))
                        {
                            // Add parameter to prevent SQL injection
                            cmd.Parameters.AddWithValue("@id", userID);

                            // Execute the query
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("User deleted successfully!");

                                // Refresh the DataGridView to reflect changes
                                LoadUsersData();
                            }
                            else
                            {
                                MessageBox.Show("Failed to delete the user.");
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
                MessageBox.Show("Please select a user to delete.");
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            string user = editUser.Text.Trim();
            string pass = editPass.Text.Trim();

            if (UserDataGrid.SelectedRows.Count > 0) // Ensure a row is selected
            {
                // Get the selected row
                DataGridViewRow selectedRow = UserDataGrid.SelectedRows[0];

                // Retrieve the user ID (assuming it's in the first column, index 0)
                int userID = Convert.ToInt32(selectedRow.Cells[0].Value);

                // Check if the username and password are provided
                if (!string.IsNullOrEmpty(user) && !string.IsNullOrEmpty(pass))
                {
                    string connectionString = @"Data Source=(localdb)\testLogin;Initial Catalog=IMS;Integrated Security=True";
                    string updateQuery = "UPDATE IMS.dbo.Users SET username = @user, passwords = @pass WHERE ID = @id";

                    try
                    {
                        using (SqlConnection con = new SqlConnection(connectionString))
                        {
                            con.Open();
                            using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                            {
                                // Add parameters to prevent SQL injection
                                cmd.Parameters.AddWithValue("@user", user);
                                cmd.Parameters.AddWithValue("@pass", pass);
                                cmd.Parameters.AddWithValue("@id", userID);

                                // Execute the query
                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("User updated successfully!");

                                    // Refresh the DataGridView to reflect changes
                                    LoadUsersData();
                                }
                                else
                                {
                                    MessageBox.Show("Failed to update the user.");
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
                    MessageBox.Show("Please enter valid values for Username and Password.");
                }
            }
            else
            {
                MessageBox.Show("Please select a user to update.");
            }

        }

    }
           
}
    

    