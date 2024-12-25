namespace IMS_FINAL
{
    partial class UserControl3
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
            panel1 = new Panel();
            totalPrice = new Label();
            productcmdBox = new ComboBox();
            categorycmdBox = new ComboBox();
            unitPriceBox = new TextBox();
            quantityBox = new TextBox();
            label8 = new Label();
            addToCart = new FontAwesome.Sharp.IconButton();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            removeProduct = new FontAwesome.Sharp.IconButton();
            salesDataGrid = new DataGridView();
            panel3 = new Panel();
            custno = new TextBox();
            label10 = new Label();
            custnam = new TextBox();
            label9 = new Label();
            clearcart = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)salesDataGrid).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(totalPrice);
            panel1.Controls.Add(productcmdBox);
            panel1.Controls.Add(categorycmdBox);
            panel1.Controls.Add(unitPriceBox);
            panel1.Controls.Add(quantityBox);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(addToCart);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(8, 86);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 262);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // totalPrice
            // 
            totalPrice.AutoSize = true;
            totalPrice.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            totalPrice.ForeColor = SystemColors.ActiveCaptionText;
            totalPrice.Location = new Point(124, 198);
            totalPrice.Name = "totalPrice";
            totalPrice.Size = new Size(0, 19);
            totalPrice.TabIndex = 21;
            // 
            // productcmdBox
            // 
            productcmdBox.FormattingEnabled = true;
            productcmdBox.Location = new Point(98, 74);
            productcmdBox.Margin = new Padding(2);
            productcmdBox.Name = "productcmdBox";
            productcmdBox.Size = new Size(124, 23);
            productcmdBox.TabIndex = 20;
            productcmdBox.SelectedIndexChanged += productcmdBox_SelectedIndexChanged;
            // 
            // categorycmdBox
            // 
            categorycmdBox.FormattingEnabled = true;
            categorycmdBox.Location = new Point(98, 34);
            categorycmdBox.Margin = new Padding(2);
            categorycmdBox.Name = "categorycmdBox";
            categorycmdBox.Size = new Size(124, 23);
            categorycmdBox.TabIndex = 19;
            categorycmdBox.SelectedIndexChanged += categorycmdBox_SelectedIndexChanged;
            // 
            // unitPriceBox
            // 
            unitPriceBox.Location = new Point(98, 113);
            unitPriceBox.Margin = new Padding(2);
            unitPriceBox.Name = "unitPriceBox";
            unitPriceBox.Size = new Size(124, 23);
            unitPriceBox.TabIndex = 18;
            // 
            // quantityBox
            // 
            quantityBox.Location = new Point(98, 151);
            quantityBox.Margin = new Padding(2);
            quantityBox.Name = "quantityBox";
            quantityBox.Size = new Size(124, 23);
            quantityBox.TabIndex = 16;
            quantityBox.TextChanged += quantityBox_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Gray;
            label8.Location = new Point(14, 10);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(130, 19);
            label8.TabIndex = 10;
            label8.Text = "Product Selection";
            // 
            // addToCart
            // 
            addToCart.BackColor = Color.BlueViolet;
            addToCart.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            addToCart.ForeColor = Color.White;
            addToCart.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            addToCart.IconColor = Color.White;
            addToCart.IconFont = FontAwesome.Sharp.IconFont.Auto;
            addToCart.IconSize = 32;
            addToCart.Location = new Point(107, 223);
            addToCart.Margin = new Padding(2);
            addToCart.Name = "addToCart";
            addToCart.Size = new Size(131, 35);
            addToCart.TabIndex = 7;
            addToCart.Text = "Add To Cart";
            addToCart.TextImageRelation = TextImageRelation.ImageBeforeText;
            addToCart.UseVisualStyleBackColor = false;
            addToCart.Click += addToCart_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(14, 199);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(78, 19);
            label7.TabIndex = 6;
            label7.Text = "Total Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(11, 116);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(72, 19);
            label6.TabIndex = 5;
            label6.Text = "Unit Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(11, 154);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(70, 19);
            label4.TabIndex = 3;
            label4.Text = "Quantity";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(11, 73);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(63, 19);
            label3.TabIndex = 2;
            label3.Text = "Product";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(11, 73);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 19);
            label2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(11, 36);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(74, 19);
            label1.TabIndex = 0;
            label1.Text = "Category";
            // 
            // panel2
            // 
            panel2.Controls.Add(iconButton3);
            panel2.Controls.Add(removeProduct);
            panel2.Controls.Add(salesDataGrid);
            panel2.Location = new Point(283, 85);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(450, 265);
            panel2.TabIndex = 1;
            // 
            // iconButton3
            // 
            iconButton3.BackColor = Color.BlueViolet;
            iconButton3.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton3.ForeColor = Color.White;
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            iconButton3.IconColor = Color.White;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.IconSize = 32;
            iconButton3.Location = new Point(309, 213);
            iconButton3.Margin = new Padding(2);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(131, 46);
            iconButton3.TabIndex = 9;
            iconButton3.Text = "Generate Bill";
            iconButton3.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton3.UseVisualStyleBackColor = false;
            iconButton3.Click += iconButton3_Click;
            // 
            // removeProduct
            // 
            removeProduct.BackColor = Color.BlueViolet;
            removeProduct.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            removeProduct.ForeColor = Color.White;
            removeProduct.IconChar = FontAwesome.Sharp.IconChar.RectangleXmark;
            removeProduct.IconColor = Color.White;
            removeProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            removeProduct.IconSize = 32;
            removeProduct.Location = new Point(10, 213);
            removeProduct.Margin = new Padding(2);
            removeProduct.Name = "removeProduct";
            removeProduct.Size = new Size(180, 46);
            removeProduct.TabIndex = 8;
            removeProduct.Text = "Remove Selected";
            removeProduct.TextImageRelation = TextImageRelation.ImageBeforeText;
            removeProduct.UseVisualStyleBackColor = false;
            removeProduct.Click += removeProduct_Click;
            // 
            // salesDataGrid
            // 
            salesDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            salesDataGrid.Location = new Point(10, 10);
            salesDataGrid.Margin = new Padding(2);
            salesDataGrid.Name = "salesDataGrid";
            salesDataGrid.RowHeadersWidth = 62;
            salesDataGrid.RowTemplate.Height = 33;
            salesDataGrid.Size = new Size(430, 192);
            salesDataGrid.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(custno);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(custnam);
            panel3.Controls.Add(label9);
            panel3.Location = new Point(8, 18);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(505, 55);
            panel3.TabIndex = 2;
            // 
            // custno
            // 
            custno.Location = new Point(370, 24);
            custno.Margin = new Padding(2);
            custno.Name = "custno";
            custno.Size = new Size(124, 23);
            custno.TabIndex = 14;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(274, 24);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(94, 19);
            label10.TabIndex = 13;
            label10.Text = "Contact No.";
            // 
            // custnam
            // 
            custnam.Location = new Point(135, 24);
            custnam.Margin = new Padding(2);
            custnam.Name = "custnam";
            custnam.Size = new Size(124, 23);
            custnam.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(11, 24);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(120, 19);
            label9.TabIndex = 11;
            label9.Text = "Customer Name";
            // 
            // clearcart
            // 
            clearcart.BackColor = Color.BlueViolet;
            clearcart.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            clearcart.ForeColor = Color.White;
            clearcart.IconChar = FontAwesome.Sharp.IconChar.CircleMinus;
            clearcart.IconColor = Color.White;
            clearcart.IconFont = FontAwesome.Sharp.IconFont.Auto;
            clearcart.IconSize = 32;
            clearcart.Location = new Point(572, 29);
            clearcart.Margin = new Padding(2);
            clearcart.Name = "clearcart";
            clearcart.Size = new Size(131, 46);
            clearcart.TabIndex = 10;
            clearcart.Text = "Clear Cart";
            clearcart.TextImageRelation = TextImageRelation.ImageBeforeText;
            clearcart.UseVisualStyleBackColor = false;
            clearcart.Click += clearcart_Click;
            // 
            // UserControl3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(clearcart);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "UserControl3";
            Size = new Size(748, 350);
            Load += UserControl3_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)salesDataGrid).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton addToCart;
        private Label label8;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton removeProduct;
        private DataGridView salesDataGrid;
        private Panel panel3;
        private TextBox custno;
        private Label label10;
        private TextBox custnam;
        private Label label9;
        private ComboBox categorycmdBox;
        private TextBox unitPriceBox;
        private TextBox quantityBox;
        private ComboBox productcmdBox;
        private Label totalPrice;
        private FontAwesome.Sharp.IconButton clearcart;
    }
}
