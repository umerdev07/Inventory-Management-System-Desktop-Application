using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS_FINAL
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            iconButton1.BringToFront();
            Sidepanel.Height = iconButton1.Height;
            Sidepanel.Top = iconButton1.Top;
            userControl61.BringToFront();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = iconButton1.Height;
            Sidepanel.Top = iconButton1.Top;
            userControl61.BringToFront();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = iconButton2.Height;
            Sidepanel.Top = iconButton2.Top;
            userControl81.BringToFront();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = iconButton2.Height;
            Sidepanel.Top = iconButton2.Top;
            userControl71.BringToFront();
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
