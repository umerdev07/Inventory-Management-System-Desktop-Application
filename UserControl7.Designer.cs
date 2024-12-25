namespace IMS_FINAL
{
    partial class UserControl7
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
            label1 = new Label();
            UserDataGrid = new DataGridView();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            editUser = new TextBox();
            editPass = new TextBox();
            ((System.ComponentModel.ISupportInitialize)UserDataGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(233, 12);
            label1.Name = "label1";
            label1.Size = new Size(123, 24);
            label1.TabIndex = 0;
            label1.Text = "VIEW USERS";
            // 
            // UserDataGrid
            // 
            UserDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UserDataGrid.Location = new Point(71, 39);
            UserDataGrid.Name = "UserDataGrid";
            UserDataGrid.RowTemplate.Height = 25;
            UserDataGrid.Size = new Size(444, 195);
            UserDataGrid.TabIndex = 1;
            UserDataGrid.CellContentClick += dataGridView1_CellContentClick;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.BlueViolet;
            iconButton1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton1.ForeColor = Color.White;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 32;
            iconButton1.Location = new Point(553, 242);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(130, 37);
            iconButton1.TabIndex = 2;
            iconButton1.Text = "EDIT";
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // iconButton2
            // 
            iconButton2.BackColor = Color.BlueViolet;
            iconButton2.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton2.ForeColor = Color.White;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.UserMinus;
            iconButton2.IconColor = Color.White;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 32;
            iconButton2.Location = new Point(553, 285);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(130, 37);
            iconButton2.TabIndex = 3;
            iconButton2.Text = "DELETE";
            iconButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton2.UseVisualStyleBackColor = false;
            iconButton2.Click += iconButton2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(192, 284);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(191, 23);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(72, 285);
            label2.Name = "label2";
            label2.Size = new Size(112, 20);
            label2.TabIndex = 5;
            label2.Text = "SEARCH USERS";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(553, 39);
            label3.Name = "label3";
            label3.Size = new Size(82, 18);
            label3.TabIndex = 6;
            label3.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(553, 122);
            label4.Name = "label4";
            label4.Size = new Size(75, 18);
            label4.TabIndex = 7;
            label4.Text = "Password";
            // 
            // editUser
            // 
            editUser.Location = new Point(550, 78);
            editUser.Name = "editUser";
            editUser.Size = new Size(133, 23);
            editUser.TabIndex = 8;
            // 
            // editPass
            // 
            editPass.Location = new Point(550, 157);
            editPass.Name = "editPass";
            editPass.Size = new Size(133, 23);
            editPass.TabIndex = 9;
            // 
            // UserControl7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(editPass);
            Controls.Add(editUser);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(iconButton2);
            Controls.Add(iconButton1);
            Controls.Add(UserDataGrid);
            Controls.Add(label1);
            Name = "UserControl7";
            Size = new Size(748, 350);
            ((System.ComponentModel.ISupportInitialize)UserDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView UserDataGrid;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox editUser;
        private TextBox editPass;
    }
}
