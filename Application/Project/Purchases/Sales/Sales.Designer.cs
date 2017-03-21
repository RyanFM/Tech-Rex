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
            this.listView1 = new System.Windows.Forms.ListView();
            this.Product_cart = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price_Cart = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Subtotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_Checkout = new System.Windows.Forms.Button();
            this.button_Remove = new System.Windows.Forms.Button();
            this.label_Total = new System.Windows.Forms.Label();
            this.groupBox_Add = new System.Windows.Forms.GroupBox();
            this.listView_Add = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Product = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label_1 = new System.Windows.Forms.Label();
            this.button_Add = new System.Windows.Forms.Button();
            this.textBox_Add = new System.Windows.Forms.TextBox();
            this.groupBox_Cart.SuspendLayout();
            this.groupBox_Add.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Cart
            // 
            this.groupBox_Cart.Controls.Add(this.listView1);
            this.groupBox_Cart.Controls.Add(this.button_Checkout);
            this.groupBox_Cart.Controls.Add(this.button_Remove);
            this.groupBox_Cart.Controls.Add(this.label_Total);
            this.groupBox_Cart.Location = new System.Drawing.Point(523, 35);
            this.groupBox_Cart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_Cart.Name = "groupBox_Cart";
            this.groupBox_Cart.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_Cart.Size = new System.Drawing.Size(577, 444);
            this.groupBox_Cart.TabIndex = 5;
            this.groupBox_Cart.TabStop = false;
            this.groupBox_Cart.Text = "CART";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Product_cart,
            this.Price_Cart,
            this.Amount,
            this.Subtotal});
            this.listView1.Location = new System.Drawing.Point(51, 34);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(489, 251);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
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
            this.groupBox_Add.Controls.Add(this.listView_Add);
            this.groupBox_Add.Controls.Add(this.label_1);
            this.groupBox_Add.Controls.Add(this.button_Add);
            this.groupBox_Add.Controls.Add(this.textBox_Add);
            this.groupBox_Add.Location = new System.Drawing.Point(46, 35);
            this.groupBox_Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_Add.Name = "groupBox_Add";
            this.groupBox_Add.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_Add.Size = new System.Drawing.Size(448, 444);
            this.groupBox_Add.TabIndex = 4;
            this.groupBox_Add.TabStop = false;
            this.groupBox_Add.Text = "ADD TO CART";
            // 
            // listView_Add
            // 
            this.listView_Add.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Product,
            this.Price});
            this.listView_Add.Location = new System.Drawing.Point(37, 182);
            this.listView_Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView_Add.Name = "listView_Add";
            this.listView_Add.Size = new System.Drawing.Size(393, 242);
            this.listView_Add.TabIndex = 3;
            this.listView_Add.UseCompatibleStateImageBehavior = false;
            this.listView_Add.View = System.Windows.Forms.View.Details;
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
            // label_1
            // 
            this.label_1.AutoSize = true;
            this.label_1.Location = new System.Drawing.Point(34, 147);
            this.label_1.Name = "label_1";
            this.label_1.Size = new System.Drawing.Size(88, 17);
            this.label_1.TabIndex = 2;
            this.label_1.Text = "INVENTORY";
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(333, 62);
            this.button_Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(97, 30);
            this.button_Add.TabIndex = 1;
            this.button_Add.Text = "ADD";
            this.button_Add.UseVisualStyleBackColor = true;
            // 
            // textBox_Add
            // 
            this.textBox_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Add.Location = new System.Drawing.Point(34, 66);
            this.textBox_Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Add.Name = "textBox_Add";
            this.textBox_Add.Size = new System.Drawing.Size(264, 24);
            this.textBox_Add.TabIndex = 0;
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 527);
            this.Controls.Add(this.groupBox_Cart);
            this.Controls.Add(this.groupBox_Add);
            this.Name = "Sales";
            this.Text = "Sales";
            this.groupBox_Cart.ResumeLayout(false);
            this.groupBox_Cart.PerformLayout();
            this.groupBox_Add.ResumeLayout(false);
            this.groupBox_Add.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Cart;
        private System.Windows.Forms.ListView listView1;
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
    }
}

