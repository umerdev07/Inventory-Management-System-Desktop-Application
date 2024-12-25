namespace IMS_FINAL
{
    partial class UserControl5
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
            cleanProductbtn = new FontAwesome.Sharp.IconButton();
            addProductbtn = new FontAwesome.Sharp.IconButton();
            addUnitPrice = new TextBox();
            label4 = new Label();
            addQuantityProduct = new TextBox();
            addCategoryName = new TextBox();
            productName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            addpback = new FontAwesome.Sharp.IconButton();
            label5 = new Label();
            minstock = new TextBox();
            SuspendLayout();
            // 
            // cleanProductbtn
            // 
            cleanProductbtn.BackColor = Color.BlueViolet;
            cleanProductbtn.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cleanProductbtn.ForeColor = Color.White;
            cleanProductbtn.IconChar = FontAwesome.Sharp.IconChar.BarsStaggered;
            cleanProductbtn.IconColor = Color.White;
            cleanProductbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            cleanProductbtn.Location = new Point(613, 192);
            cleanProductbtn.Margin = new Padding(2);
            cleanProductbtn.Name = "cleanProductbtn";
            cleanProductbtn.Size = new Size(111, 57);
            cleanProductbtn.TabIndex = 19;
            cleanProductbtn.Text = "Clear";
            cleanProductbtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            cleanProductbtn.UseVisualStyleBackColor = false;
            cleanProductbtn.Click += cleanProductbtn_Click;
            // 
            // addProductbtn
            // 
            addProductbtn.BackColor = Color.BlueViolet;
            addProductbtn.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addProductbtn.ForeColor = Color.White;
            addProductbtn.IconChar = FontAwesome.Sharp.IconChar.BoxesStacked;
            addProductbtn.IconColor = Color.White;
            addProductbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            addProductbtn.Location = new Point(613, 123);
            addProductbtn.Margin = new Padding(2);
            addProductbtn.Name = "addProductbtn";
            addProductbtn.Size = new Size(111, 53);
            addProductbtn.TabIndex = 18;
            addProductbtn.Text = "Add";
            addProductbtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            addProductbtn.UseVisualStyleBackColor = false;
            addProductbtn.Click += addProductbtn_Click;
            // 
            // addUnitPrice
            // 
            addUnitPrice.Location = new Point(384, 190);
            addUnitPrice.Margin = new Padding(2);
            addUnitPrice.Name = "addUnitPrice";
            addUnitPrice.Size = new Size(196, 23);
            addUnitPrice.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(384, 154);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 16;
            label4.Text = "Unit Price";
            // 
            // addQuantityProduct
            // 
            addQuantityProduct.Location = new Point(26, 265);
            addQuantityProduct.Margin = new Padding(2);
            addQuantityProduct.Name = "addQuantityProduct";
            addQuantityProduct.Size = new Size(249, 23);
            addQuantityProduct.TabIndex = 15;
            // 
            // addCategoryName
            // 
            addCategoryName.Location = new Point(26, 190);
            addCategoryName.Margin = new Padding(2);
            addCategoryName.Name = "addCategoryName";
            addCategoryName.Size = new Size(249, 23);
            addCategoryName.TabIndex = 14;
            // 
            // productName
            // 
            productName.Location = new Point(26, 95);
            productName.Margin = new Padding(2);
            productName.Name = "productName";
            productName.Size = new Size(554, 23);
            productName.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(26, 229);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 12;
            label3.Text = "Quantity";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(26, 154);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(127, 20);
            label2.TabIndex = 11;
            label2.Text = "Category Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(26, 67);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(115, 20);
            label1.TabIndex = 10;
            label1.Text = "Product Name";
            // 
            // addpback
            // 
            addpback.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            addpback.IconChar = FontAwesome.Sharp.IconChar.CaretLeft;
            addpback.IconColor = Color.BlueViolet;
            addpback.IconFont = FontAwesome.Sharp.IconFont.Auto;
            addpback.IconSize = 35;
            addpback.Location = new Point(22, 13);
            addpback.Name = "addpback";
            addpback.Size = new Size(40, 32);
            addpback.TabIndex = 20;
            addpback.UseVisualStyleBackColor = true;
            addpback.Click += addpback_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(384, 229);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(118, 20);
            label5.TabIndex = 21;
            label5.Text = "Minimum Stock";
            // 
            // minstock
            // 
            minstock.Location = new Point(384, 265);
            minstock.Margin = new Padding(2);
            minstock.Name = "minstock";
            minstock.Size = new Size(196, 23);
            minstock.TabIndex = 22;
            // 
            // UserControl5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(minstock);
            Controls.Add(label5);
            Controls.Add(addpback);
            Controls.Add(cleanProductbtn);
            Controls.Add(addProductbtn);
            Controls.Add(addUnitPrice);
            Controls.Add(label4);
            Controls.Add(addQuantityProduct);
            Controls.Add(addCategoryName);
            Controls.Add(productName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "UserControl5";
            Size = new Size(748, 350);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton cleanProductbtn;
        private FontAwesome.Sharp.IconButton addProductbtn;
        private TextBox addUnitPrice;
        private Label label4;
        private TextBox addQuantityProduct;
        private TextBox addCategoryName;
        private TextBox productName;
        private Label label3;
        private Label label2;
        private Label label1;
        private FontAwesome.Sharp.IconButton addpback;
        private Label label5;
        private TextBox minstock;
    }
}
