namespace IMS_FINAL
{
    partial class AdminForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            Sidepanel = new Panel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            userControl61 = new UserControl6();
            userControl71 = new UserControl7();
            userControl81 = new UserControl8();
            backbtn = new FontAwesome.Sharp.IconPictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)backbtn).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(40, 40, 43);
            panel1.Controls.Add(backbtn);
            panel1.Controls.Add(iconButton3);
            panel1.Controls.Add(iconButton2);
            panel1.Controls.Add(Sidepanel);
            panel1.Controls.Add(iconButton1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(160, 391);
            panel1.TabIndex = 0;
            // 
            // iconButton3
            // 
            iconButton3.FlatAppearance.BorderSize = 0;
            iconButton3.FlatStyle = FlatStyle.Flat;
            iconButton3.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton3.ForeColor = Color.White;
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton3.IconColor = Color.Black;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.Location = new Point(1, 228);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(160, 42);
            iconButton3.TabIndex = 3;
            iconButton3.Text = "Manage Users";
            iconButton3.UseVisualStyleBackColor = true;
            iconButton3.Click += iconButton3_Click;
            // 
            // iconButton2
            // 
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton2.ForeColor = Color.White;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.Location = new Point(0, 174);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(160, 42);
            iconButton2.TabIndex = 2;
            iconButton2.Text = "Add User";
            iconButton2.UseVisualStyleBackColor = true;
            iconButton2.Click += iconButton2_Click;
            // 
            // Sidepanel
            // 
            Sidepanel.BackColor = Color.BlueViolet;
            Sidepanel.Location = new Point(1, 107);
            Sidepanel.Name = "Sidepanel";
            Sidepanel.Size = new Size(10, 40);
            Sidepanel.TabIndex = 1;
            // 
            // iconButton1
            // 
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton1.ForeColor = Color.White;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(0, 105);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(160, 42);
            iconButton1.TabIndex = 1;
            iconButton1.Text = "Dashboard";
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // userControl61
            // 
            userControl61.Location = new Point(156, 0);
            userControl61.Name = "userControl61";
            userControl61.Size = new Size(748, 391);
            userControl61.TabIndex = 4;
            // 
            // userControl71
            // 
            userControl71.Location = new Point(156, 0);
            userControl71.Name = "userControl71";
            userControl71.Size = new Size(748, 391);
            userControl71.TabIndex = 5;
            // 
            // userControl81
            // 
            userControl81.Location = new Point(156, 0);
            userControl81.Name = "userControl81";
            userControl81.Size = new Size(783, 391);
            userControl81.TabIndex = 6;
            // 
            // backbtn
            // 
            backbtn.BackColor = Color.FromArgb(40, 40, 43);
            backbtn.ForeColor = Color.BlueViolet;
            backbtn.IconChar = FontAwesome.Sharp.IconChar.CaretLeft;
            backbtn.IconColor = Color.BlueViolet;
            backbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            backbtn.Location = new Point(12, 12);
            backbtn.Name = "backbtn";
            backbtn.Size = new Size(32, 32);
            backbtn.TabIndex = 7;
            backbtn.TabStop = false;
            backbtn.Click += iconPictureBox1_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 391);
            Controls.Add(userControl81);
            Controls.Add(userControl71);
            Controls.Add(userControl61);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "AdminForm";
            Text = "AdminForm";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)backbtn).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private Panel Sidepanel;
        private UserControl6 userControl61;
        private UserControl7 userControl71;
        private UserControl8 userControl81;
        private FontAwesome.Sharp.IconPictureBox backbtn;
    }
}