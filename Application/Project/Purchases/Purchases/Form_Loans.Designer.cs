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
            this.listView_Add = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name_Add = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label_Inventory = new System.Windows.Forms.Label();
            this.button_Add = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox_Cart = new System.Windows.Forms.GroupBox();
            this.button_Checkout = new System.Windows.Forms.Button();
            this.button_Remove = new System.Windows.Forms.Button();
            this.label_Total = new System.Windows.Forms.Label();
            this.listView_Cart = new System.Windows.Forms.ListView();
            this.Name_Cart = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Deposit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ID_Cart = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Subtotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_GoBack = new System.Windows.Forms.Button();
            this.groupBox_Add.SuspendLayout();
            this.groupBox_Cart.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Add
            // 
            this.groupBox_Add.Controls.Add(this.listView_Add);
            this.groupBox_Add.Controls.Add(this.label_Inventory);
            this.groupBox_Add.Controls.Add(this.button_Add);
            this.groupBox_Add.Controls.Add(this.textBox1);
            this.groupBox_Add.Location = new System.Drawing.Point(28, 79);
            this.groupBox_Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_Add.Name = "groupBox_Add";
            this.groupBox_Add.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_Add.Size = new System.Drawing.Size(368, 374);
            this.groupBox_Add.TabIndex = 1;
            this.groupBox_Add.TabStop = false;
            this.groupBox_Add.Text = "ADD TO CART";
            // 
            // listView_Add
            // 
            this.listView_Add.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Name_Add,
            this.Price});
            this.listView_Add.Location = new System.Drawing.Point(28, 203);
            this.listView_Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView_Add.Name = "listView_Add";
            this.listView_Add.Size = new System.Drawing.Size(313, 151);
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
            // 
            // Price
            // 
            this.Price.Text = "Price";
            // 
            // label_Inventory
            // 
            this.label_Inventory.AutoSize = true;
            this.label_Inventory.Location = new System.Drawing.Point(28, 144);
            this.label_Inventory.Name = "label_Inventory";
            this.label_Inventory.Size = new System.Drawing.Size(66, 17);
            this.label_Inventory.TabIndex = 2;
            this.label_Inventory.Text = "Inventory";
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(257, 44);
            this.button_Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(84, 21);
            this.button_Add.TabIndex = 1;
            this.button_Add.Text = "ADD";
            this.button_Add.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(28, 44);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(199, 22);
            this.textBox1.TabIndex = 0;
            // 
            // groupBox_Cart
            // 
            this.groupBox_Cart.Controls.Add(this.button_Checkout);
            this.groupBox_Cart.Controls.Add(this.button_Remove);
            this.groupBox_Cart.Controls.Add(this.label_Total);
            this.groupBox_Cart.Controls.Add(this.listView_Cart);
            this.groupBox_Cart.Location = new System.Drawing.Point(420, 79);
            this.groupBox_Cart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_Cart.Name = "groupBox_Cart";
            this.groupBox_Cart.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_Cart.Size = new System.Drawing.Size(372, 374);
            this.groupBox_Cart.TabIndex = 2;
            this.groupBox_Cart.TabStop = false;
            this.groupBox_Cart.Text = "CART";
            // 
            // button_Checkout
            // 
            this.button_Checkout.Location = new System.Drawing.Point(236, 295);
            this.button_Checkout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Checkout.Name = "button_Checkout";
            this.button_Checkout.Size = new System.Drawing.Size(112, 38);
            this.button_Checkout.TabIndex = 13;
            this.button_Checkout.Text = "CHECK OUT";
            this.button_Checkout.UseVisualStyleBackColor = true;
            // 
            // button_Remove
            // 
            this.button_Remove.Location = new System.Drawing.Point(236, 248);
            this.button_Remove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Remove.Name = "button_Remove";
            this.button_Remove.Size = new System.Drawing.Size(112, 38);
            this.button_Remove.TabIndex = 12;
            this.button_Remove.Text = "REMOVE";
            this.button_Remove.UseVisualStyleBackColor = true;
            // 
            // label_Total
            // 
            this.label_Total.AutoSize = true;
            this.label_Total.Location = new System.Drawing.Point(38, 231);
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
            this.ID_Cart,
            this.Subtotal});
            this.listView_Cart.Location = new System.Drawing.Point(28, 35);
            this.listView_Cart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView_Cart.Name = "listView_Cart";
            this.listView_Cart.Size = new System.Drawing.Size(320, 157);
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
            // ID_Cart
            // 
            this.ID_Cart.Text = "ID";
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
            // Form_Loans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 534);
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

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox_Add;
        private System.Windows.Forms.ListView listView_Add;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Name_Add;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.Label label_Inventory;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox_Cart;
        private System.Windows.Forms.ListView listView_Cart;
        private System.Windows.Forms.ColumnHeader Name_Cart;
        private System.Windows.Forms.ColumnHeader Deposit;
        private System.Windows.Forms.ColumnHeader ID_Cart;
        private System.Windows.Forms.ColumnHeader Subtotal;
        private System.Windows.Forms.Label label_Total;
        private System.Windows.Forms.Button button_Checkout;
        private System.Windows.Forms.Button button_Remove;
        private System.Windows.Forms.Button button_GoBack;
    }
}