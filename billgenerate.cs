using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;


namespace IMS_FINAL
{
    public partial class billgenerate : UserControl
    {

        public string customerNames { get; set; }
        public string customerNumbers { get; set; }
        public DataGridView salesData { get; set; }

        public string TOTALPRICE { get; set; }
      
        public billgenerate()
        {
            InitializeComponent();
            date.Text = DateTime.Now.ToString("MM/dd/yyyy");
            time.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            // Hide the current UserControl (this control)
            this.Hide();

            // Create an instance of UserControl3
            UserControl3 userControl3 = new UserControl3();

            // Find the parent form (Form1)
            Form1 parentForm = (Form1)this.FindForm();

            // Clear existing controls in Form1 (optional, based on your needs)


            // Add UserControl3 to the form
            parentForm.Controls.Add(userControl3);
            userControl3.Dock = DockStyle.Fill; // Ensure UserControl3 fills the form

            // Bring UserControl3 to the front
            userControl3.BringToFront();
        }


        private void billgenerate_Load(object sender, EventArgs e)
        {
            // Use customerName and customerNumber properties in the UI
            if (!string.IsNullOrEmpty(customerNames) && !string.IsNullOrEmpty(customerNumbers))
            {
                label8.Text = customerNames;
                label9.Text = customerNumbers;
                total_price.Text = TOTALPRICE.ToString();
            }


            // Display sales data in the bill grid view if available
            if (salesData != null)
            {
                billDataGrid.DataSource = salesData.DataSource; // Assuming billDataGridView is the grid in billgenerate
            }
        }

        private void date_Click(object sender, EventArgs e)
        {
            // Assuming you have a Label named 'dateLabel' to display the date
            date.Text = DateTime.Now.ToString("MM/dd/yyyy"); // Adjust the format as needed
        }

        private void time_Click(object sender, EventArgs e)
        {
            // Display the current time in a desired format (e.g., HH:mm:ss for 24-hour format)
            time.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a new workbook
                using (var workbook = new XLWorkbook())
                {
                    // Add a worksheet
                    var worksheet = workbook.Worksheets.Add("Invoice");

                    // Header for customer details
                    worksheet.Cell(1, 1).Value = "Customer Name";
                    worksheet.Cell(1, 2).Value = "Customer Number";
                    worksheet.Cell(1, 3).Value = "Date";
                    worksheet.Cell(1, 4).Value = "Time";
                    worksheet.Cell(1, 6).Value = "Total Price";

                    // Add customer details
                    worksheet.Cell(2, 1).Value = customerNames;
                    worksheet.Cell(2, 2).Value = customerNumbers;
                    worksheet.Cell(2, 3).Value = DateTime.Now.ToString("MM/dd/yyyy");
                    worksheet.Cell(2, 4).Value = DateTime.Now.ToString("HH:mm:ss");
                    worksheet.Cell(2, 6).Value = TOTALPRICE;

                    // Header for items
                    worksheet.Cell(4, 5).Value = "Product";
                    worksheet.Cell(4, 6).Value = "UnitPrice";

                    // Add items from sales data
                    if (salesData != null && salesData.Rows.Count > 0)
                    {
                        int itemRowStart = 5; // Start adding items from row 5
                        foreach (DataGridViewRow row in salesData.Rows)
                        {
                            if (!row.IsNewRow)
                            {
                                worksheet.Cell(itemRowStart, 5).Value = row.Cells["Product"]?.Value?.ToString() ?? string.Empty;
                                worksheet.Cell(itemRowStart, 6).Value = row.Cells["UnitPrice"]?.Value?.ToString() ?? string.Empty;
                                itemRowStart++;
                            }
                        }
                    }

                    // Auto-adjust column widths
                    worksheet.Columns().AdjustToContents();

                    // Create a new folder with the current time
                    string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    string folderName = System.IO.Path.Combine(documentsPath, DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss"));
                    System.IO.Directory.CreateDirectory(folderName); // Create the folder

                    // Save the workbook in the new folder
                    string fileName = System.IO.Path.Combine(folderName, "Invoice.xlsx");
                    workbook.SaveAs(fileName);

                    // Notify the user
                    MessageBox.Show($"Invoice saved to {fileName}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}