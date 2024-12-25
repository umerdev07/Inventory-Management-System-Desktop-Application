namespace IMS_FINAL
{
    partial class UserControl2
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
            productListGrid = new DataGridView();
            label2 = new Label();
            searchProduct = new TextBox();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            panel1 = new Panel();
            deleteProduct = new Button();
            updateProduct = new Button();
            viewAllProducts = new Button();
            button1 = new Button();
            pricetxt = new TextBox();
            quantitytxt = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)productListGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(183, 41);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(113, 23);
            label1.TabIndex = 0;
            label1.Text = "Product List";
            // 
            // productListGrid
            // 
            productListGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productListGrid.Location = new Point(27, 71);
            productListGrid.Margin = new Padding(2);
            productListGrid.Name = "productListGrid";
            productListGrid.RowHeadersWidth = 62;
            productListGrid.RowTemplate.Height = 33;
            productListGrid.Size = new Size(466, 228);
            productListGrid.TabIndex = 1;
            productListGrid.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(27, 315);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(144, 22);
            label2.TabIndex = 2;
            label2.Text = "Product Name";
            // 
            // searchProduct
            // 
            searchProduct.Location = new Point(180, 319);
            searchProduct.Margin = new Padding(2);
            searchProduct.Name = "searchProduct";
            searchProduct.Size = new Size(268, 23);
            searchProduct.TabIndex = 3;
            searchProduct.TextChanged += searchProduct_TextChanged;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = SystemColors.Control;
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 29;
            iconPictureBox1.Location = new Point(458, 319);
            iconPictureBox1.Margin = new Padding(2);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(34, 29);
            iconPictureBox1.TabIndex = 4;
            iconPictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(deleteProduct);
            panel1.Controls.Add(updateProduct);
            panel1.Controls.Add(viewAllProducts);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pricetxt);
            panel1.Controls.Add(quantitytxt);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(507, 127);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(239, 211);
            panel1.TabIndex = 5;
            // 
            // deleteProduct
            // 
            deleteProduct.BackColor = Color.BlueViolet;
            deleteProduct.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            deleteProduct.ForeColor = Color.White;
            deleteProduct.Location = new Point(134, 161);
            deleteProduct.Name = "deleteProduct";
            deleteProduct.Size = new Size(85, 43);
            deleteProduct.TabIndex = 9;
            deleteProduct.Text = "Delete Product";
            deleteProduct.UseVisualStyleBackColor = false;
            deleteProduct.Click += deleteProduct_Click;
            // 
            // updateProduct
            // 
            updateProduct.BackColor = Color.BlueViolet;
            updateProduct.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            updateProduct.ForeColor = Color.White;
            updateProduct.Location = new Point(13, 161);
            updateProduct.Name = "updateProduct";
            updateProduct.Size = new Size(85, 43);
            updateProduct.TabIndex = 8;
            updateProduct.Text = "Update Product";
            updateProduct.UseVisualStyleBackColor = false;
            updateProduct.Click += updateProduct_Click;
            // 
            // viewAllProducts
            // 
            viewAllProducts.BackColor = Color.BlueViolet;
            viewAllProducts.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            viewAllProducts.ForeColor = Color.White;
            viewAllProducts.Location = new Point(134, 109);
            viewAllProducts.Name = "viewAllProducts";
            viewAllProducts.Size = new Size(85, 43);
            viewAllProducts.TabIndex = 7;
            viewAllProducts.Text = "View all Product";
            viewAllProducts.UseVisualStyleBackColor = false;
            viewAllProducts.Click += viewAllProducts_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.BlueViolet;
            button1.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(13, 108);
            button1.Name = "button1";
            button1.Size = new Size(85, 43);
            button1.TabIndex = 6;
            button1.Text = "Select Product";
            button1.UseVisualStyleBackColor = false;
            // 
            // pricetxt
            // 
            pricetxt.Location = new Point(126, 80);
            pricetxt.Name = "pricetxt";
            pricetxt.Size = new Size(100, 23);
            pricetxt.TabIndex = 5;
            // 
            // quantitytxt
            // 
            quantitytxt.Location = new Point(5, 79);
            quantitytxt.Name = "quantitytxt";
            quantitytxt.Size = new Size(100, 23);
            quantitytxt.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(158, 55);
            label6.Name = "label6";
            label6.Size = new Size(37, 16);
            label6.TabIndex = 3;
            label6.Text = "Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(24, 55);
            label5.Name = "label5";
            label5.Size = new Size(55, 16);
            label5.TabIndex = 2;
            label5.Text = "Quantity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(65, 27);
            label4.Name = "label4";
            label4.Size = new Size(103, 17);
            label4.TabIndex = 1;
            label4.Text = "Product Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(87, 6);
            label3.Name = "label3";
            label3.Size = new Size(50, 18);
            label3.TabIndex = 0;
            label3.Text = "Menu";
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.BlueViolet;
            iconButton1.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton1.ForeColor = Color.White;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.BoxesStacked;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(522, 72);
            iconButton1.Margin = new Padding(2);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(200, 51);
            iconButton1.TabIndex = 6;
            iconButton1.Text = "Add Product";
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // UserControl2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(iconButton1);
            Controls.Add(panel1);
            Controls.Add(iconPictureBox1);
            Controls.Add(searchProduct);
            Controls.Add(label2);
            Controls.Add(productListGrid);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "UserControl2";
            Size = new Size(748, 350);
            Load += UserControl2_Load_1;
            ((System.ComponentModel.ISupportInitialize)productListGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView productListGrid;
        private Label label2;
        private TextBox searchProduct;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label label4;
        private Label label3;
        private Label label5;
        private Label label6;
        private TextBox quantitytxt;
        private TextBox pricetxt;
        private Button viewAllProducts;
        private Button button1;
        private Button updateProduct;
        private Button deleteProduct;
    }
}
