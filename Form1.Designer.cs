namespace IMS_FINAL
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            Sidepanel = new Panel();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            textBox1 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            userControl11 = new UserControl1();
            userControl21 = new UserControl2();
            userControl31 = new UserControl3();
            userControl41 = new UserControl4();
            userControl51 = new UserControl5();
            billgenerate1 = new billgenerate();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(40, 40, 43);
            panel1.Controls.Add(Sidepanel);
            panel1.Controls.Add(iconButton4);
            panel1.Controls.Add(iconButton3);
            panel1.Controls.Add(iconButton2);
            panel1.Controls.Add(iconButton1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(189, 395);
            panel1.TabIndex = 0;
            // 
            // Sidepanel
            // 
            Sidepanel.BackColor = Color.BlueViolet;
            Sidepanel.Location = new Point(0, 103);
            Sidepanel.Margin = new Padding(2);
            Sidepanel.Name = "Sidepanel";
            Sidepanel.Size = new Size(8, 28);
            Sidepanel.TabIndex = 2;
            // 
            // iconButton4
            // 
            iconButton4.FlatAppearance.BorderSize = 0;
            iconButton4.FlatStyle = FlatStyle.Flat;
            iconButton4.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton4.ForeColor = Color.White;
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            iconButton4.IconColor = Color.White;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton4.Location = new Point(0, 265);
            iconButton4.Margin = new Padding(2);
            iconButton4.Name = "iconButton4";
            iconButton4.Padding = new Padding(7, 0, 0, 0);
            iconButton4.Size = new Size(189, 43);
            iconButton4.TabIndex = 5;
            iconButton4.Text = "Logout";
            iconButton4.TextAlign = ContentAlignment.MiddleLeft;
            iconButton4.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton4.UseVisualStyleBackColor = true;
            iconButton4.Click += iconButton4_Click;
            // 
            // iconButton3
            // 
            iconButton3.FlatAppearance.BorderSize = 0;
            iconButton3.FlatStyle = FlatStyle.Flat;
            iconButton3.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton3.ForeColor = Color.White;
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.CartShopping;
            iconButton3.IconColor = Color.WhiteSmoke;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton3.Location = new Point(0, 208);
            iconButton3.Margin = new Padding(2);
            iconButton3.Name = "iconButton3";
            iconButton3.Padding = new Padding(7, 0, 0, 0);
            iconButton3.Size = new Size(189, 43);
            iconButton3.TabIndex = 4;
            iconButton3.Text = "Sales";
            iconButton3.TextAlign = ContentAlignment.MiddleLeft;
            iconButton3.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton3.UseVisualStyleBackColor = true;
            iconButton3.Click += iconButton3_Click;
            // 
            // iconButton2
            // 
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton2.ForeColor = Color.White;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.BoxOpen;
            iconButton2.IconColor = Color.White;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton2.Location = new Point(0, 148);
            iconButton2.Margin = new Padding(2);
            iconButton2.Name = "iconButton2";
            iconButton2.Padding = new Padding(7, 0, 0, 0);
            iconButton2.Size = new Size(189, 43);
            iconButton2.TabIndex = 3;
            iconButton2.Text = "Inventory";
            iconButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton2.UseVisualStyleBackColor = true;
            iconButton2.Click += iconButton2_Click;
            // 
            // iconButton1
            // 
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton1.ForeColor = Color.White;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(0, 96);
            iconButton1.Margin = new Padding(2);
            iconButton1.Name = "iconButton1";
            iconButton1.Padding = new Padding(7, 0, 0, 0);
            iconButton1.Size = new Size(189, 43);
            iconButton1.TabIndex = 2;
            iconButton1.Text = "Dashboard";
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.BlueViolet;
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(189, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(748, 41);
            panel2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.BlueViolet;
            textBox1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(265, 9);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(148, 27);
            textBox1.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(452, 13);
            dateTimePicker1.Margin = new Padding(2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(211, 23);
            dateTimePicker1.TabIndex = 0;
            dateTimePicker1.Visible = false;
            // 
            // userControl11
            // 
            userControl11.Location = new Point(189, 43);
            userControl11.Margin = new Padding(1);
            userControl11.Name = "userControl11";
            userControl11.Size = new Size(1123, 526);
            userControl11.TabIndex = 2;
            // 
            // userControl21
            // 
            userControl21.Location = new Point(189, 43);
            userControl21.Margin = new Padding(1);
            userControl21.Name = "userControl21";
            userControl21.Size = new Size(1123, 526);
            userControl21.TabIndex = 3;
            // 
            // userControl31
            // 
            userControl31.Location = new Point(189, 43);
            userControl31.Margin = new Padding(1);
            userControl31.Name = "userControl31";
            userControl31.Size = new Size(1123, 526);
            userControl31.TabIndex = 4;
            // 
            // userControl41
            // 
            userControl41.Location = new Point(189, 43);
            userControl41.Margin = new Padding(1);
            userControl41.Name = "userControl41";
            userControl41.Size = new Size(1123, 526);
            userControl41.TabIndex = 5;
            // 
            // userControl51
            // 
            userControl51.Location = new Point(189, 35);
            userControl51.Margin = new Padding(1);
            userControl51.Name = "userControl51";
            userControl51.Size = new Size(1123, 526);
            userControl51.TabIndex = 6;
            // 
            // billgenerate1
            // 
            billgenerate1.customerNames = null;
            billgenerate1.customerNumbers = null;
            billgenerate1.Location = new Point(189, 35);
            billgenerate1.Name = "billgenerate1";
            billgenerate1.salesData = null;
            billgenerate1.Size = new Size(748, 362);
            billgenerate1.TabIndex = 7;
            billgenerate1.TOTALPRICE = null;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(937, 395);
            Controls.Add(billgenerate1);
            Controls.Add(userControl51);
            Controls.Add(userControl41);
            Controls.Add(userControl31);
            Controls.Add(userControl21);
            Controls.Add(userControl11);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Panel Sidepanel;
        private UserControl1 userControl11;
        private UserControl2 userControl21;
        private UserControl3 userControl31;
        private UserControl4 userControl41;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private UserControl5 userControl51;
        private billgenerate billgenerate1;
    }
}