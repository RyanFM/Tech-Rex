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
            this.lblAmount = new System.Windows.Forms.Label();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.listView_Add = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name_Add = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Stock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label_Inventory = new System.Windows.Forms.Label();
            this.button_Add = new System.Windows.Forms.Button();
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
            this.btnUsb = new System.Windows.Forms.Button();
            this.btnCharger = new System.Windows.Forms.Button();
            this.btnHeadphone = new System.Windows.Forms.Button();
            this.btnTablet = new System.Windows.Forms.Button();
            this.btnGoPro = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox_Add.SuspendLayout();
            this.groupBox_Cart.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Add
            // 
            this.groupBox_Add.Controls.Add(this.tableLayoutPanel1);
            this.groupBox_Add.Controls.Add(this.lblAmount);
            this.groupBox_Add.Controls.Add(this.btnPlus);
            this.groupBox_Add.Controls.Add(this.btnMin);
            this.groupBox_Add.Controls.Add(this.listView_Add);
            this.groupBox_Add.Controls.Add(this.label_Inventory);
            this.groupBox_Add.Controls.Add(this.button_Add);
            this.groupBox_Add.Location = new System.Drawing.Point(28, 79);
            this.groupBox_Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_Add.Name = "groupBox_Add";
            this.groupBox_Add.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_Add.Size = new System.Drawing.Size(661, 629);
            this.groupBox_Add.TabIndex = 1;
            this.groupBox_Add.TabStop = false;
            this.groupBox_Add.Text = "ADD TO CART";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblAmount.Location = new System.Drawing.Point(520, 45);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(44, 48);
            this.lblAmount.TabIndex = 17;
            this.lblAmount.Text = "0";
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnPlus.Location = new System.Drawing.Point(570, 45);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(58, 57);
            this.btnPlus.TabIndex = 16;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMin
            // 
            this.btnMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnMin.Location = new System.Drawing.Point(439, 41);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(57, 57);
            this.btnMin.TabIndex = 15;
            this.btnMin.Text = "-";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // listView_Add
            // 
            this.listView_Add.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Name_Add,
            this.Price,
            this.Stock});
            this.listView_Add.Location = new System.Drawing.Point(36, 342);
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
            this.label_Inventory.Location = new System.Drawing.Point(33, 316);
            this.label_Inventory.Name = "label_Inventory";
            this.label_Inventory.Size = new System.Drawing.Size(66, 17);
            this.label_Inventory.TabIndex = 2;
            this.label_Inventory.Text = "Inventory";
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(499, 107);
            this.button_Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(129, 48);
            this.button_Add.TabIndex = 1;
            this.button_Add.Text = "ADD";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // groupBox_Cart
            // 
            this.groupBox_Cart.Controls.Add(this.lbTotal);
            this.groupBox_Cart.Controls.Add(this.button_Checkout);
            this.groupBox_Cart.Controls.Add(this.button_Remove);
            this.groupBox_Cart.Controls.Add(this.label_Total);
            this.groupBox_Cart.Controls.Add(this.listView_Cart);
            this.groupBox_Cart.Location = new System.Drawing.Point(721, 79);
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
            this.lbTotal.Size = new System.Drawing.Size(44, 17);
            this.lbTotal.TabIndex = 14;
            this.lbTotal.Text = "€0.00";
            // 
            // button_Checkout
            // 
            this.button_Checkout.Location = new System.Drawing.Point(396, 342);
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
            // btnUsb
            // 
            this.btnUsb.BackgroundImage = global::Purchases.Properties.Resources.USB_cable;
            this.btnUsb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUsb.Location = new System.Drawing.Point(3, 123);
            this.btnUsb.Name = "btnUsb";
            this.btnUsb.Size = new System.Drawing.Size(114, 114);
            this.btnUsb.TabIndex = 14;
            this.btnUsb.UseVisualStyleBackColor = true;
            this.btnUsb.Click += new System.EventHandler(this.btnUsb_Click);
            // 
            // btnCharger
            // 
            this.btnCharger.BackgroundImage = global::Purchases.Properties.Resources.Laptop_Charger;
            this.btnCharger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCharger.Location = new System.Drawing.Point(123, 123);
            this.btnCharger.Name = "btnCharger";
            this.btnCharger.Size = new System.Drawing.Size(114, 114);
            this.btnCharger.TabIndex = 13;
            this.btnCharger.UseVisualStyleBackColor = true;
            this.btnCharger.Click += new System.EventHandler(this.btnCharger_Click);
            // 
            // btnHeadphone
            // 
            this.btnHeadphone.BackgroundImage = global::Purchases.Properties.Resources.Headphones;
            this.btnHeadphone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHeadphone.Location = new System.Drawing.Point(243, 3);
            this.btnHeadphone.Name = "btnHeadphone";
            this.btnHeadphone.Size = new System.Drawing.Size(120, 114);
            this.btnHeadphone.TabIndex = 12;
            this.btnHeadphone.UseVisualStyleBackColor = true;
            this.btnHeadphone.Click += new System.EventHandler(this.btnHeadphone_Click);
            // 
            // btnTablet
            // 
            this.btnTablet.BackgroundImage = global::Purchases.Properties.Resources.Tablet;
            this.btnTablet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTablet.Location = new System.Drawing.Point(123, 3);
            this.btnTablet.Name = "btnTablet";
            this.btnTablet.Size = new System.Drawing.Size(114, 114);
            this.btnTablet.TabIndex = 11;
            this.btnTablet.UseVisualStyleBackColor = true;
            this.btnTablet.Click += new System.EventHandler(this.btnTablet_Click);
            // 
            // btnGoPro
            // 
            this.btnGoPro.BackgroundImage = global::Purchases.Properties.Resources.GoPro;
            this.btnGoPro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGoPro.Location = new System.Drawing.Point(3, 3);
            this.btnGoPro.Name = "btnGoPro";
            this.btnGoPro.Size = new System.Drawing.Size(114, 114);
            this.btnGoPro.TabIndex = 10;
            this.btnGoPro.UseVisualStyleBackColor = true;
            this.btnGoPro.Click += new System.EventHandler(this.btnGoPro_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.Controls.Add(this.btnTablet, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnGoPro, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnHeadphone, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnUsb, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnCharger, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(33, 38);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(366, 240);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // Form_Loans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 784);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbShop);
            this.Controls.Add(this.button_GoBack);
            this.Controls.Add(this.groupBox_Cart);
            this.Controls.Add(this.groupBox_Add);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_Loans";
            this.Text = "Form_Loans";
            this.Load += new System.EventHandler(this.Form_Loans_Load);
            this.groupBox_Add.ResumeLayout(false);
            this.groupBox_Add.PerformLayout();
            this.groupBox_Cart.ResumeLayout(false);
            this.groupBox_Cart.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
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
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Button btnUsb;
        private System.Windows.Forms.Button btnCharger;
        private System.Windows.Forms.Button btnHeadphone;
        private System.Windows.Forms.Button btnTablet;
        private System.Windows.Forms.Button btnGoPro;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}