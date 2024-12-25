using System;
using System.Drawing;
using System.Windows.Forms; // Ensure Windows Forms namespace is included

namespace IMS_FINAL
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timer; // Explicitly specify Windows Forms Timer

        public Form1()
        {
            InitializeComponent();

            // Setup Sidepanel
            Sidepanel.Height = iconButton1.Height;
            Sidepanel.Top = iconButton1.Top;
            userControl11.BringToFront();

            // Style and Configure the TextBox
            textBox1.BorderStyle = BorderStyle.None; // Remove Border
            textBox1.ForeColor = Color.White;
            textBox1.ReadOnly = true; // Prevent Manual Input

            // Initialize Timer
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick; 
            timer.Start(); 
        }

       
        private void Timer_Tick(object sender, EventArgs e)
        {
            textBox1.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = iconButton1.Height;
            Sidepanel.Top = iconButton1.Top;
            userControl11.BringToFront();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = iconButton2.Height;
            Sidepanel.Top = iconButton2.Top;
            userControl21.BringToFront();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = iconButton3.Height;
            Sidepanel.Top = iconButton3.Top;
            userControl31.BringToFront();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            // Show a confirmation dialog
            DialogResult result = MessageBox.Show(
                "Are you sure you want to log out?", 
                "Confirm Logout",                   
                MessageBoxButtons.YesNo,            
                MessageBoxIcon.Question             
            );

            
            if (result == DialogResult.Yes)
            {
                PerformLogout(); 
            }
            else
            {
               
                MessageBox.Show("Logout cancelled.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void PerformLogout()
        {
          
            MessageBox.Show("You have been logged out successfully.", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information);

            NavigateToForm2();
        }

        private void NavigateToForm2()
        {
           
            Form2 form2 = new Form2();

           
            form2.Show();

            
            this.Hide();  
        }

    }
}
