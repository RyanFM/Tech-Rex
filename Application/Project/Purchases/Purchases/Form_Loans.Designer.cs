namespace Purchases
{
    partial class Form_Loans
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
            this.groupBox_Add = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbProducts = new System.Windows.Forms.ComboBox();
            this.listView_Add = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name_Add = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Stock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label_Inventory = new System.Windows.Forms.Label();
            this.button_Add = new System.Windows.Forms.Button();
            this.tbAdd = new System.Windows.Forms.TextBox();
            this.groupBox_Cart = new System.Windows.Forms.GroupBox();
            this.lbTotal = new System.Windows.Forms.Label();
            this.button_Checkout = new System.Windows.Forms.Button();
            this.button_Remove = new System.Windows.Forms.Button();
            this.label_Total = new System.Windows.Forms.Label();
            this.listView_Cart = new System.Windows.Forms.ListView();
            this.Name_Cart = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Deposit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Subtotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_GoBack = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbShop = new System.Windows.Forms.ComboBox();
            this.groupBox_Add.SuspendLayout();
            this.groupBox_Cart.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Add
            // 
            this.groupBox_Add.Controls.Add(this.label1);
            this.groupBox_Add.Controls.Add(this.label2);
            this.groupBox_Add.Controls.Add(this.cbProducts);
            this.groupBox_Add.Controls.Add(this.listView_Add);
            this.groupBox_Add.Controls.Add(this.label_Inventory);
            this.groupBox_Add.Controls.Add(this.button_Add);
            this.groupBox_Add.Controls.Add(this.tbAdd);
            this.groupBox_Add.Location = new System.Drawing.Point(28, 79);
            this.groupBox_Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_Add.Name = "groupBox_Add";
            this.groupBox_Add.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_Add.Size = new System.Drawing.Size(456, 494);
            this.groupBox_Add.TabIndex = 1;
            this.groupBox_Add.TabStop = false;
            this.groupBox_Add.Text = "ADD TO CART";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Amount:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Product:";
            // 
            // cbProducts
            // 
            this.cbProducts.FormattingEnabled = true;
            this.cbProducts.Location = new System.Drawing.Point(227, 134);
            this.cbProducts.Name = "cbProducts";
            this.cbProducts.Size = new System.Drawing.Size(73, 24);
            this.cbProducts.TabIndex = 7;
            // 
            // listView_Add
            // 
            this.listView_Add.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Name_Add,
            this.Price,
            this.Stock});
            this.listView_Add.Location = new System.Drawing.Point(41, 230);
            this.listView_Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView_Add.Name = "listView_Add";
            this.listView_Add.Size = new System.Drawing.Size(381, 236);
            this.listView_Add.TabIndex = 3;
            this.listView_Add.UseCompatibleStateImageBehavior = false;
            this.listView_Add.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // Name_Add
            // 
            this.Name_Add.Text = "Name";
            this.Name_Add.Width = 104;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            // 
            // Stock
            // 
            this.Stock.Text = "Stock";
            this.Stock.Width = 68;
            // 
            // label_Inventory
            // 
            this.label_Inventory.AutoSize = true;
            this.label_Inventory.Location = new System.Drawing.Point(38, 197);
            this.label_Inventory.Name = "label_Inventory";
            this.label_Inventory.Size = new System.Drawing.Size(66, 17);
            this.label_Inventory.TabIndex = 2;
            this.label_Inventory.Text = "Inventory";
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(325, 45);
            this.button_Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(97, 28);
            this.button_Add.TabIndex = 1;
            this.button_Add.Text = "ADD";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // tbAdd
            // 
            this.tbAdd.Location = new System.Drawing.Point(227, 51);
            this.tbAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAdd.Name = "tbAdd";
            this.tbAdd.Size = new System.Drawing.Size(76, 22);
            this.tbAdd.TabIndex = 0;
            // 
            // groupBox_Cart
            // 
            this.groupBox_Cart.Controls.Add(this.lbTotal);
            this.groupBox_Cart.Controls.Add(this.button_Checkout);
            this.groupBox_Cart.Controls.Add(this.button_Remove);
            this.groupBox_Cart.Controls.Add(this.label_Total);
            this.groupBox_Cart.Controls.Add(this.listView_Cart);
            this.groupBox_Cart.Location = new System.Drawing.Point(515, 89);
            this.groupBox_Cart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_Cart.Name = "groupBox_Cart";
            this.groupBox_Cart.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_Cart.Size = new System.Drawing.Size(529, 484);
            this.groupBox_Cart.TabIndex = 2;
            this.groupBox_Cart.TabStop = false;
            this.groupBox_Cart.Text = "CART";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(188, 279);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(36, 17);
            this.lbTotal.TabIndex = 14;
            this.lbTotal.Text = "0.00";
            // 
            // button_Checkout
            // 
            this.button_Checkout.Location = new System.Drawing.Point(396, 326);
            this.button_Checkout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Checkout.Name = "button_Checkout";
            this.button_Checkout.Size = new System.Drawing.Size(112, 38);
            this.button_Checkout.TabIndex = 13;
            this.button_Checkout.Text = "CHECK OUT";
            this.button_Checkout.UseVisualStyleBackColor = true;
            this.button_Checkout.Click += new System.EventHandler(this.button_Checkout_Click);
            // 
            // button_Remove
            // 
            this.button_Remove.Location = new System.Drawing.Point(396, 279);
            this.button_Remove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Remove.Name = "button_Remove";
            this.button_Remove.Size = new System.Drawing.Size(112, 38);
            this.button_Remove.TabIndex = 12;
            this.button_Remove.Text = "REMOVE";
            this.button_Remove.UseVisualStyleBackColor = true;
            this.button_Remove.Click += new System.EventHandler(this.button_Remove_Click);
            // 
            // label_Total
            // 
            this.label_Total.AutoSize = true;
            this.label_Total.Location = new System.Drawing.Point(138, 279);
            this.label_Total.Name = "label_Total";
            this.label_Total.Size = new System.Drawing.Size(44, 17);
            this.label_Total.TabIndex = 10;
            this.label_Total.Text = "Total:";
            // 
            // listView_Cart
            // 
            this.listView_Cart.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name_Cart,
            this.Deposit,
            this.Amount,
            this.Subtotal});
            this.listView_Cart.Location = new System.Drawing.Point(28, 35);
            this.listView_Cart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView_Cart.Name = "listView_Cart";
            this.listView_Cart.Size = new System.Drawing.Size(480, 194);
            this.listView_Cart.TabIndex = 0;
            this.listView_Cart.UseCompatibleStateImageBehavior = false;
            this.listView_Cart.View = System.Windows.Forms.View.Details;
            // 
            // Name_Cart
            // 
            this.Name_Cart.Text = "Name";
            // 
            // Deposit
            // 
            this.Deposit.Text = "Deposit";
            // 
            // Amount
            // 
            this.Amount.Text = "Amount";
            // 
            // Subtotal
            // 
            this.Subtotal.Text = "Subtotal";
            // 
            // button_GoBack
            // 
            this.button_GoBack.Location = new System.Drawing.Point(844, 11);
            this.button_GoBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_GoBack.Name = "button_GoBack";
            this.button_GoBack.Size = new System.Drawing.Size(112, 38);
            this.button_GoBack.TabIndex = 19;
            this.button_GoBack.Text = "Go Back";
            this.button_GoBack.UseVisualStyleBackColor = true;
            this.button_GoBack.Click += new System.EventHandler(this.button_GoBack_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Shop ID:";
            // 
            // cbShop
            // 
            this.cbShop.FormattingEnabled = true;
            this.cbShop.Location = new System.Drawing.Point(98, 25);
            this.cbShop.Name = "cbShop";
            this.cbShop.Size = new System.Drawing.Size(54, 24);
            this.cbShop.TabIndex = 20;
            this.cbShop.SelectedIndexChanged += new System.EventHandler(this.cbShop_SelectedIndexChanged);
            // 
            // Form_Loans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 644);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbShop);
            this.Controls.Add(this.button_GoBack);
            this.Controls.Add(this.groupBox_Cart);
            this.Controls.Add(this.groupBox_Add);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_Loans";
            this.Text = "Form_Loans";
            this.groupBox_Add.ResumeLayout(false);
            this.groupBox_Add.PerformLayout();
            this.groupBox_Cart.ResumeLayout(false);
            this.groupBox_Cart.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox_Add;
        private System.Windows.Forms.ListView listView_Add;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Name_Add;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.Label label_Inventory;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.TextBox tbAdd;
        private System.Windows.Forms.GroupBox groupBox_Cart;
        private System.Windows.Forms.ListView listView_Cart;
        private System.Windows.Forms.ColumnHeader Name_Cart;
        private System.Windows.Forms.ColumnHeader Deposit;
        private System.Windows.Forms.ColumnHeader Amount;
        private System.Windows.Forms.ColumnHeader Subtotal;
        private System.Windows.Forms.Label label_Total;
        private System.Windows.Forms.Button button_Checkout;
        private System.Windows.Forms.Button button_Remove;
        private System.Windows.Forms.Button button_GoBack;
        private System.Windows.Forms.ColumnHeader Stock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbShop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbProducts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTotal;
    }
}