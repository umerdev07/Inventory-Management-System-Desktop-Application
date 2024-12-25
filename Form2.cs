using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace IMS_FINAL
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            // Get the trimmed input from text boxes
            string username = txtbox1.Text.Trim();
            string password = txtbox2.Text.Trim();

            // Validate that the username contains only letters using regex
            if (!Regex.IsMatch(username, @"^[A-Za-z]"))
            {
                MessageBox.Show("Username can only contain letters and no numbers or special characters.");
                return;
            }

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in both username and password.");
                return;
            }

            string connectionString = @"Data Source=(localdb)\testLogin;Initial Catalog=IMS;Integrated Security=True";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Check if credentials belong to the Admin table (case-sensitive query)
                    string adminQuery = @"
            SELECT COUNT(*) 
            FROM IMS.dbo.Admin 
            WHERE Adminname COLLATE Latin1_General_BIN = @username 
              AND Adminpassword = @password";
                    using (SqlCommand adminCommand = new SqlCommand(adminQuery, connection))
                    {
                        adminCommand.Parameters.AddWithValue("@username", username);
                        adminCommand.Parameters.AddWithValue("@password", password);

                        int isAdmin = Convert.ToInt32(adminCommand.ExecuteScalar() ?? 0);
                        if (isAdmin > 0)
                        {
                            MessageBox.Show("Welcome, Admin!");
                            AdminForm adminForm = new AdminForm();
                            this.Hide();
                            adminForm.Show();
                            return;
                        }
                    }

                    // Check if credentials belong to the Users table (case-sensitive query)
                    string userQuery = @"
            SELECT COUNT(*) 
            FROM IMS.dbo.Users 
            WHERE username COLLATE Latin1_General_BIN = @username 
              AND passwords = @password";
                    using (SqlCommand userCommand = new SqlCommand(userQuery, connection))
                    {
                        userCommand.Parameters.AddWithValue("@username", username);
                        userCommand.Parameters.AddWithValue("@password", password);

                        int isUser = Convert.ToInt32(userCommand.ExecuteScalar() ?? 0);
                        if (isUser > 0)
                        {
                            MessageBox.Show("Login successful!");
                            Form1 form1 = new Form1();
                            this.Hide();
                            form1.Show();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to log in. Please try again later.");
                Console.WriteLine(ex); // Log the detailed error
            }
        }

    }
}
