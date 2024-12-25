namespace IMS_FINAL
{
    partial class UserControl1
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            panel1 = new Panel();
            numberOfSales = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(numberOfSales);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(56, 140);
            panel1.Name = "panel1";
            panel1.Size = new Size(311, 73);
            panel1.TabIndex = 6;
            // 
            // numberOfSales
            // 
            numberOfSales.AutoSize = true;
            numberOfSales.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            numberOfSales.Location = new Point(235, 32);
            numberOfSales.Name = "numberOfSales";
            numberOfSales.Size = new Size(0, 17);
            numberOfSales.TabIndex = 3;
            numberOfSales.Click += numberOfSales_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 26);
            label2.Name = "label2";
            label2.Size = new Size(210, 23);
            label2.TabIndex = 2;
            label2.Text = "Total number of Sales:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(454, 87);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(238, 229);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(217, 35);
            label1.Name = "label1";
            label1.Size = new Size(270, 19);
            label1.TabIndex = 4;
            label1.Text = "INVENTORY MANAGEMENT SYSTEM";
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "UserControl1";
            Size = new Size(748, 350);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label numberOfSales;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label1;
    }
}
