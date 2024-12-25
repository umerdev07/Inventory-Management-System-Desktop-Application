namespace IMS_FINAL
{
    partial class billgenerate
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            billDataGrid = new DataGridView();
            label1 = new Label();
            total_price = new Label();
            label2 = new Label();
            date = new Label();
            time = new Label();
            panel1 = new Panel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            label8 = new Label();
            label9 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)billDataGrid).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(308, 64);
            label3.Name = "label3";
            label3.Size = new Size(100, 25);
            label3.TabIndex = 2;
            label3.Text = "INVOICE";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(73, 107);
            label4.Name = "label4";
            label4.Size = new Size(110, 17);
            label4.TabIndex = 3;
            label4.Text = "Customer Name :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(73, 137);
            label5.Name = "label5";
            label5.Size = new Size(121, 17);
            label5.TabIndex = 4;
            label5.Text = "Customer Number :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(446, 107);
            label6.Name = "label6";
            label6.Size = new Size(44, 17);
            label6.TabIndex = 5;
            label6.Text = "Date :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(446, 137);
            label7.Name = "label7";
            label7.Size = new Size(41, 17);
            label7.TabIndex = 6;
            label7.Text = "Time :";
            // 
            // billDataGrid
            // 
            billDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            billDataGrid.Location = new Point(48, 165);
            billDataGrid.Name = "billDataGrid";
            billDataGrid.RowTemplate.Height = 25;
            billDataGrid.Size = new Size(653, 136);
            billDataGrid.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(264, 314);
            label1.Name = "label1";
            label1.Size = new Size(73, 25);
            label1.TabIndex = 12;
            label1.Text = "TOTAL";
            // 
            // total_price
            // 
            total_price.AutoSize = true;
            total_price.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            total_price.ForeColor = Color.Black;
            total_price.Location = new Point(363, 314);
            total_price.Name = "total_price";
            total_price.Size = new Size(77, 25);
            total_price.TabIndex = 13;
            total_price.Text = "RS 210";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.BlueViolet;
            label2.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.BlanchedAlmond;
            label2.Location = new Point(334, 19);
            label2.Name = "label2";
            label2.Size = new Size(48, 25);
            label2.TabIndex = 14;
            label2.Text = "BILL";
            // 
            // date
            // 
            date.AutoSize = true;
            date.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            date.Location = new Point(516, 107);
            date.Name = "date";
            date.Size = new Size(52, 17);
            date.TabIndex = 17;
            date.Text = "label11";
            date.Click += date_Click;
            // 
            // time
            // 
            time.AutoSize = true;
            time.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            time.Location = new Point(516, 137);
            time.Name = "time";
            time.Size = new Size(52, 17);
            time.TabIndex = 18;
            time.Text = "label12";
            time.Click += time_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.BlueViolet;
            panel1.Controls.Add(iconPictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(748, 58);
            panel1.TabIndex = 19;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.BlueViolet;
            iconPictureBox1.ForeColor = SystemColors.ButtonHighlight;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.CaretLeft;
            iconPictureBox1.IconColor = SystemColors.ButtonHighlight;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.Location = new Point(17, 16);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(32, 32);
            iconPictureBox1.TabIndex = 0;
            iconPictureBox1.TabStop = false;
            iconPictureBox1.Click += iconPictureBox1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(209, 109);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 20;
            label8.Text = "label8";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(209, 138);
            label9.Name = "label9";
            label9.Size = new Size(38, 15);
            label9.TabIndex = 21;
            label9.Text = "label9";
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.BlueViolet;
            iconButton1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton1.ForeColor = Color.White;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(610, 309);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(91, 34);
            iconButton1.TabIndex = 22;
            iconButton1.Text = "Save";
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // billgenerate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(iconButton1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(time);
            Controls.Add(date);
            Controls.Add(label2);
            Controls.Add(total_price);
            Controls.Add(label1);
            Controls.Add(billDataGrid);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            Name = "billgenerate";
            Size = new Size(748, 350);
            Load += billgenerate_Load;
            ((System.ComponentModel.ISupportInitialize)billDataGrid).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private DataGridView billDataGrid;
        private Label label1;
        private Label total_price;
        private Label label2;
        private Label customerName;
        private Label customerNumber;
        private Label date;
        private Label time;
        private Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label label8;
        private Label label9;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}
