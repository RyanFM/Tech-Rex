namespace Sales
{
    partial class Sales
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
            this.groupBox_Cart = new System.Windows.Forms.GroupBox();
            this.lbTotal = new System.Windows.Forms.Label();
            this.listView_Cart = new System.Windows.Forms.ListView();
            this.Product_cart = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price_Cart = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Subtotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_Checkout = new System.Windows.Forms.Button();
            this.button_Remove = new System.Windows.Forms.Button();
            this.label_Total = new System.Windows.Forms.Label();
            this.groupBox_Add = new System.Windows.Forms.GroupBox();
            this.btnCola = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbProducts = new System.Windows.Forms.ComboBox();
            this.listView_Add = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Product = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Stock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label_1 = new System.Windows.Forms.Label();
            this.button_Add = new System.Windows.Forms.Button();
            this.textBox_Add = new System.Windows.Forms.TextBox();
            this.cbShop = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbtest2 = new System.Windows.Forms.Label();
            this.btnCroquette = new System.Windows.Forms.Button();
            this.btnHeiniken = new System.Windows.Forms.Button();
            this.btnFries = new System.Windows.Forms.Button();
            this.btnDoner = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.lblAmount = new System.Windows.Forms.Label();
            this.groupBox_Cart.SuspendLayout();
            this.groupBox_Add.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Cart
            // 
            this.groupBox_Cart.Controls.Add(this.lbTotal);
            this.groupBox_Cart.Controls.Add(this.listView_Cart);
            this.groupBox_Cart.Controls.Add(this.button_Checkout);
            this.groupBox_Cart.Controls.Add(this.button_Remove);
            this.groupBox_Cart.Controls.Add(this.label_Total);
            this.groupBox_Cart.Location = new System.Drawing.Point(956, 134);
            this.groupBox_Cart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_Cart.Name = "groupBox_Cart";
            this.groupBox_Cart.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_Cart.Size = new System.Drawing.Size(577, 515);
            this.groupBox_Cart.TabIndex = 5;
            this.groupBox_Cart.TabStop = false;
            this.groupBox_Cart.Text = "CART";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(218, 313);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(44, 17);
            this.lbTotal.TabIndex = 7;
            this.lbTotal.Text = "€0.00";
            // 
            // listView_Cart
            // 
            this.listView_Cart.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Product_cart,
            this.Price_Cart,
            this.Amount,
            this.Subtotal});
            this.listView_Cart.Location = new System.Drawing.Point(51, 34);
            this.listView_Cart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView_Cart.Name = "listView_Cart";
            this.listView_Cart.Size = new System.Drawing.Size(489, 251);
            this.listView_Cart.TabIndex = 6;
            this.listView_Cart.UseCompatibleStateImageBehavior = false;
            this.listView_Cart.View = System.Windows.Forms.View.Details;
            // 
            // Product_cart
            // 
            this.Product_cart.Text = "Name";
            // 
            // Price_Cart
            // 
            this.Price_Cart.Text = "Price";
            // 
            // Amount
            // 
            this.Amount.Text = "Amount";
            // 
            // Subtotal
            // 
            this.Subtotal.Text = "Subtotal";
            this.Subtotal.Width = 114;
            // 
            // button_Checkout
            // 
            this.button_Checkout.Location = new System.Drawing.Point(429, 365);
            this.button_Checkout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Checkout.Name = "button_Checkout";
            this.button_Checkout.Size = new System.Drawing.Size(110, 38);
            this.button_Checkout.TabIndex = 5;
            this.button_Checkout.Text = "CHECK OUT";
            this.button_Checkout.UseVisualStyleBackColor = true;
            this.button_Checkout.Click += new System.EventHandler(this.button_Checkout_Click);
            // 
            // button_Remove
            // 
            this.button_Remove.Location = new System.Drawing.Point(429, 302);
            this.button_Remove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Remove.Name = "button_Remove";
            this.button_Remove.Size = new System.Drawing.Size(110, 38);
            this.button_Remove.TabIndex = 4;
            this.button_Remove.Text = "Remove";
            this.button_Remove.UseVisualStyleBackColor = true;
            this.button_Remove.Click += new System.EventHandler(this.button_Remove_Click);
            // 
            // label_Total
            // 
            this.label_Total.AutoSize = true;
            this.label_Total.Location = new System.Drawing.Point(167, 313);
            this.label_Total.Name = "label_Total";
            this.label_Total.Size = new System.Drawing.Size(44, 17);
            this.label_Total.TabIndex = 2;
            this.label_Total.Text = "Total:";
            // 
            // groupBox_Add
            // 
            this.groupBox_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox_Add.Controls.Add(this.btnDoner);
            this.groupBox_Add.Controls.Add(this.lblAmount);
            this.groupBox_Add.Controls.Add(this.btnMin);
            this.groupBox_Add.Controls.Add(this.btnPlus);
            this.groupBox_Add.Controls.Add(this.btnFries);
            this.groupBox_Add.Controls.Add(this.btnHeiniken);
            this.groupBox_Add.Controls.Add(this.btnCroquette);
            this.groupBox_Add.Controls.Add(this.btnCola);
            this.groupBox_Add.Controls.Add(this.label2);
            this.groupBox_Add.Controls.Add(this.label1);
            this.groupBox_Add.Controls.Add(this.cbProducts);
            this.groupBox_Add.Controls.Add(this.listView_Add);
            this.groupBox_Add.Controls.Add(this.label_1);
            this.groupBox_Add.Controls.Add(this.button_Add);
            this.groupBox_Add.Controls.Add(this.textBox_Add);
            this.groupBox_Add.Location = new System.Drawing.Point(27, 134);
            this.groupBox_Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_Add.Name = "groupBox_Add";
            this.groupBox_Add.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_Add.Size = new System.Drawing.Size(903, 680);
            this.groupBox_Add.TabIndex = 4;
            this.groupBox_Add.TabStop = false;
            this.groupBox_Add.Text = "ADD TO CART";
            // 
            // btnCola
            // 
            this.btnCola.BackgroundImage = global::Sales.Properties.Resources.Coca_Cola1;
            this.btnCola.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCola.Location = new System.Drawing.Point(244, 217);
            this.btnCola.Name = "btnCola";
            this.btnCola.Size = new System.Drawing.Size(72, 155);
            this.btnCola.TabIndex = 7;
            this.btnCola.UseVisualStyleBackColor = true;
            this.btnCola.Click += new System.EventHandler(this.btnCola_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 612);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Product:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 541);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Amount:";
            // 
            // cbProducts
            // 
            this.cbProducts.FormattingEnabled = true;
            this.cbProducts.Location = new System.Drawing.Point(139, 609);
            this.cbProducts.Name = "cbProducts";
            this.cbProducts.Size = new System.Drawing.Size(73, 24);
            this.cbProducts.TabIndex = 4;
            // 
            // listView_Add
            // 
            this.listView_Add.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Product,
            this.Price,
            this.Stock});
            this.listView_Add.Location = new System.Drawing.Point(477, 434);
            this.listView_Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView_Add.Name = "listView_Add";
            this.listView_Add.Size = new System.Drawing.Size(393, 242);
            this.listView_Add.TabIndex = 3;
            this.listView_Add.UseCompatibleStateImageBehavior = false;
            this.listView_Add.View = System.Windows.Forms.View.Details;
            this.listView_Add.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView_Add_ItemSelectionChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 70;
            // 
            // Product
            // 
            this.Product.Tag = "";
            this.Product.Text = "Name";
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.Width = 68;
            // 
            // Stock
            // 
            this.Stock.Text = "Stock";
            this.Stock.Width = 68;
            // 
            // label_1
            // 
            this.label_1.AutoSize = true;
            this.label_1.Location = new System.Drawing.Point(474, 399);
            this.label_1.Name = "label_1";
            this.label_1.Size = new System.Drawing.Size(88, 17);
            this.label_1.TabIndex = 2;
            this.label_1.Text = "INVENTORY";
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(733, 198);
            this.button_Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(122, 53);
            this.button_Add.TabIndex = 1;
            this.button_Add.Text = "ADD";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // textBox_Add
            // 
            this.textBox_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Add.Location = new System.Drawing.Point(139, 536);
            this.textBox_Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Add.Name = "textBox_Add";
            this.textBox_Add.Size = new System.Drawing.Size(73, 24);
            this.textBox_Add.TabIndex = 0;
            // 
            // cbShop
            // 
            this.cbShop.FormattingEnabled = true;
            this.cbShop.Location = new System.Drawing.Point(92, 38);
            this.cbShop.Name = "cbShop";
            this.cbShop.Size = new System.Drawing.Size(54, 24);
            this.cbShop.TabIndex = 6;
            this.cbShop.SelectedIndexChanged += new System.EventHandler(this.cbShop_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Shop ID:";
            // 
            // lbtest2
            // 
            this.lbtest2.AutoSize = true;
            this.lbtest2.Location = new System.Drawing.Point(588, 54);
            this.lbtest2.Name = "lbtest2";
            this.lbtest2.Size = new System.Drawing.Size(46, 17);
            this.lbtest2.TabIndex = 8;
            this.lbtest2.Text = "label4";
            // 
            // btnCroquette
            // 
            this.btnCroquette.BackgroundImage = global::Sales.Properties.Resources.Croquette1;
            this.btnCroquette.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCroquette.Location = new System.Drawing.Point(309, 85);
            this.btnCroquette.Name = "btnCroquette";
            this.btnCroquette.Size = new System.Drawing.Size(117, 123);
            this.btnCroquette.TabIndex = 8;
            this.btnCroquette.UseVisualStyleBackColor = true;
            this.btnCroquette.Click += new System.EventHandler(this.btnCroquette_Click);
            // 
            // btnHeiniken
            // 
            this.btnHeiniken.BackgroundImage = global::Sales.Properties.Resources.Heiniken1;
            this.btnHeiniken.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHeiniken.Location = new System.Drawing.Point(114, 232);
            this.btnHeiniken.Name = "btnHeiniken";
            this.btnHeiniken.Size = new System.Drawing.Size(63, 140);
            this.btnHeiniken.TabIndex = 11;
            this.btnHeiniken.UseVisualStyleBackColor = true;
            this.btnHeiniken.Click += new System.EventHandler(this.btnHeiniken_Click);
            // 
            // btnFries
            // 
            this.btnFries.BackgroundImage = global::Sales.Properties.Resources.French_fries1;
            this.btnFries.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFries.Location = new System.Drawing.Point(167, 85);
            this.btnFries.Name = "btnFries";
            this.btnFries.Size = new System.Drawing.Size(117, 123);
            this.btnFries.TabIndex = 12;
            this.btnFries.UseVisualStyleBackColor = true;
            this.btnFries.Click += new System.EventHandler(this.btnFries_Click);
            // 
            // btnDoner
            // 
            this.btnDoner.BackgroundImage = global::Sales.Properties.Resources.Doner_kebab1;
            this.btnDoner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDoner.Location = new System.Drawing.Point(28, 83);
            this.btnDoner.Name = "btnDoner";
            this.btnDoner.Size = new System.Drawing.Size(117, 125);
            this.btnDoner.TabIndex = 13;
            this.btnDoner.UseVisualStyleBackColor = true;
            this.btnDoner.Click += new System.EventHandler(this.btnDoner_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnPlus.Location = new System.Drawing.Point(795, 105);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(60, 62);
            this.btnPlus.TabIndex = 14;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.SystemColors.Control;
            this.btnMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnMin.Location = new System.Drawing.Point(595, 105);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(60, 62);
            this.btnMin.TabIndex = 15;
            this.btnMin.Text = "-";
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblAmount.Location = new System.Drawing.Point(700, 112);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(44, 48);
            this.lblAmount.TabIndex = 16;
            this.lblAmount.Text = "0";
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1545, 897);
            this.Controls.Add(this.lbtest2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbShop);
            this.Controls.Add(this.groupBox_Cart);
            this.Controls.Add(this.groupBox_Add);
            this.Name = "Sales";
            this.Text = "Sales";
            this.groupBox_Cart.ResumeLayout(false);
            this.groupBox_Cart.PerformLayout();
            this.groupBox_Add.ResumeLayout(false);
            this.groupBox_Add.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Cart;
        private System.Windows.Forms.ListView listView_Cart;
        private System.Windows.Forms.ColumnHeader Product_cart;
        private System.Windows.Forms.ColumnHeader Price_Cart;
        private System.Windows.Forms.ColumnHeader Amount;
        private System.Windows.Forms.ColumnHeader Subtotal;
        private System.Windows.Forms.Button button_Checkout;
        private System.Windows.Forms.Button button_Remove;
        private System.Windows.Forms.Label label_Total;
        private System.Windows.Forms.GroupBox groupBox_Add;
        private System.Windows.Forms.ListView listView_Add;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Product;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.Label label_1;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.TextBox textBox_Add;
        private System.Windows.Forms.ColumnHeader Stock;
        private System.Windows.Forms.ComboBox cbShop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbProducts;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbtest2;
        private System.Windows.Forms.Button btnCola;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnDoner;
        private System.Windows.Forms.Button btnFries;
        private System.Windows.Forms.Button btnHeiniken;
        private System.Windows.Forms.Button btnCroquette;
    }
}

