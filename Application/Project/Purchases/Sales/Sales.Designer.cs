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
            this.button_Remove = new System.Windows.Forms.Button();
            this.label_Total = new System.Windows.Forms.Label();
            this.groupBox_Add = new System.Windows.Forms.GroupBox();
            this.tlpnMenu = new System.Windows.Forms.TableLayoutPanel();
            this.lblAmount = new System.Windows.Forms.Label();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.listView_Add = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Product = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Stock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label_1 = new System.Windows.Forms.Label();
            this.button_Add = new System.Windows.Forms.Button();
            this.cbShop = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnHotdog = new System.Windows.Forms.Button();
            this.btnBavaria = new System.Windows.Forms.Button();
            this.btnAmstel = new System.Windows.Forms.Button();
            this.btnCoffee = new System.Windows.Forms.Button();
            this.btnFries = new System.Windows.Forms.Button();
            this.btnDoner = new System.Windows.Forms.Button();
            this.btnCroquette = new System.Windows.Forms.Button();
            this.btnHeiniken = new System.Windows.Forms.Button();
            this.btnCola = new System.Windows.Forms.Button();
            this.pnlTopBorder = new System.Windows.Forms.Panel();
            this.lbSwipe = new System.Windows.Forms.Label();
            this.pnlSwipe = new System.Windows.Forms.Panel();
            this.pnMenuBorder = new System.Windows.Forms.Panel();
            this.groupBox_Cart.SuspendLayout();
            this.groupBox_Add.SuspendLayout();
            this.tlpnMenu.SuspendLayout();
            this.pnlTopBorder.SuspendLayout();
            this.pnlSwipe.SuspendLayout();
            this.pnMenuBorder.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Cart
            // 
            this.groupBox_Cart.BackColor = System.Drawing.Color.Honeydew;
            this.groupBox_Cart.Controls.Add(this.pnlSwipe);
            this.groupBox_Cart.Controls.Add(this.lbTotal);
            this.groupBox_Cart.Controls.Add(this.listView_Cart);
            this.groupBox_Cart.Controls.Add(this.button_Remove);
            this.groupBox_Cart.Controls.Add(this.label_Total);
            this.groupBox_Cart.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox_Cart.Location = new System.Drawing.Point(759, 134);
            this.groupBox_Cart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_Cart.Name = "groupBox_Cart";
            this.groupBox_Cart.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_Cart.Size = new System.Drawing.Size(577, 475);
            this.groupBox_Cart.TabIndex = 5;
            this.groupBox_Cart.TabStop = false;
            this.groupBox_Cart.Text = "CART";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbTotal.Location = new System.Drawing.Point(209, 306);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(71, 29);
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
            // button_Remove
            // 
            this.button_Remove.BackColor = System.Drawing.Color.Maroon;
            this.button_Remove.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.button_Remove.FlatAppearance.BorderSize = 3;
            this.button_Remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_Remove.ForeColor = System.Drawing.SystemColors.Menu;
            this.button_Remove.Location = new System.Drawing.Point(403, 302);
            this.button_Remove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Remove.Name = "button_Remove";
            this.button_Remove.Size = new System.Drawing.Size(136, 48);
            this.button_Remove.TabIndex = 4;
            this.button_Remove.Text = "Remove";
            this.button_Remove.UseVisualStyleBackColor = false;
            this.button_Remove.Click += new System.EventHandler(this.button_Remove_Click);
            // 
            // label_Total
            // 
            this.label_Total.AutoSize = true;
            this.label_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_Total.Location = new System.Drawing.Point(138, 306);
            this.label_Total.Name = "label_Total";
            this.label_Total.Size = new System.Drawing.Size(74, 29);
            this.label_Total.TabIndex = 2;
            this.label_Total.Text = "Total:";
            // 
            // groupBox_Add
            // 
            this.groupBox_Add.BackColor = System.Drawing.Color.Honeydew;
            this.groupBox_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox_Add.Controls.Add(this.pnMenuBorder);
            this.groupBox_Add.Controls.Add(this.lblAmount);
            this.groupBox_Add.Controls.Add(this.btnMin);
            this.groupBox_Add.Controls.Add(this.btnPlus);
            this.groupBox_Add.Controls.Add(this.listView_Add);
            this.groupBox_Add.Controls.Add(this.label_1);
            this.groupBox_Add.Controls.Add(this.button_Add);
            this.groupBox_Add.Location = new System.Drawing.Point(27, 134);
            this.groupBox_Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_Add.Name = "groupBox_Add";
            this.groupBox_Add.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_Add.Size = new System.Drawing.Size(698, 811);
            this.groupBox_Add.TabIndex = 4;
            this.groupBox_Add.TabStop = false;
            this.groupBox_Add.Text = "ADD TO CART";
            // 
            // tlpnMenu
            // 
            this.tlpnMenu.ColumnCount = 3;
            this.tlpnMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlpnMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlpnMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tlpnMenu.Controls.Add(this.btnHotdog, 2, 1);
            this.tlpnMenu.Controls.Add(this.btnBavaria, 0, 2);
            this.tlpnMenu.Controls.Add(this.btnAmstel, 0, 2);
            this.tlpnMenu.Controls.Add(this.btnCoffee, 0, 2);
            this.tlpnMenu.Controls.Add(this.btnFries, 1, 0);
            this.tlpnMenu.Controls.Add(this.btnDoner, 2, 0);
            this.tlpnMenu.Controls.Add(this.btnCroquette, 0, 0);
            this.tlpnMenu.Controls.Add(this.btnHeiniken, 0, 1);
            this.tlpnMenu.Controls.Add(this.btnCola, 1, 1);
            this.tlpnMenu.Location = new System.Drawing.Point(6, 7);
            this.tlpnMenu.Name = "tlpnMenu";
            this.tlpnMenu.RowCount = 3;
            this.tlpnMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlpnMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlpnMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlpnMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpnMenu.Size = new System.Drawing.Size(365, 362);
            this.tlpnMenu.TabIndex = 17;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblAmount.Location = new System.Drawing.Point(524, 53);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(44, 48);
            this.lblAmount.TabIndex = 16;
            this.lblAmount.Text = "0";
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.Maroon;
            this.btnMin.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnMin.FlatAppearance.BorderSize = 4;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnMin.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnMin.Location = new System.Drawing.Point(430, 46);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(60, 62);
            this.btnMin.TabIndex = 15;
            this.btnMin.Text = "-";
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnPlus.FlatAppearance.BorderColor = System.Drawing.Color.OliveDrab;
            this.btnPlus.FlatAppearance.BorderSize = 4;
            this.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnPlus.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnPlus.Location = new System.Drawing.Point(584, 46);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(60, 62);
            this.btnPlus.TabIndex = 14;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // listView_Add
            // 
            this.listView_Add.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Product,
            this.Price,
            this.Stock});
            this.listView_Add.Location = new System.Drawing.Point(29, 497);
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
            this.label_1.Location = new System.Drawing.Point(26, 458);
            this.label_1.Name = "label_1";
            this.label_1.Size = new System.Drawing.Size(88, 17);
            this.label_1.TabIndex = 2;
            this.label_1.Text = "INVENTORY";
            // 
            // button_Add
            // 
            this.button_Add.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.button_Add.FlatAppearance.BorderColor = System.Drawing.Color.OliveDrab;
            this.button_Add.FlatAppearance.BorderSize = 3;
            this.button_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_Add.ForeColor = System.Drawing.SystemColors.Menu;
            this.button_Add.Location = new System.Drawing.Point(532, 132);
            this.button_Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(122, 53);
            this.button_Add.TabIndex = 1;
            this.button_Add.Text = "ADD";
            this.button_Add.UseVisualStyleBackColor = false;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // cbShop
            // 
            this.cbShop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbShop.FormattingEnabled = true;
            this.cbShop.Items.AddRange(new object[] {
            "Bob\'s Bar",
            "The Ceiling",
            "De Krokante Friet"});
            this.cbShop.Location = new System.Drawing.Point(165, 15);
            this.cbShop.Name = "cbShop";
            this.cbShop.Size = new System.Drawing.Size(256, 24);
            this.cbShop.TabIndex = 6;
            this.cbShop.SelectedIndexChanged += new System.EventHandler(this.cbShop_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(22, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Shop name:";
            // 
            // btnHotdog
            // 
            this.btnHotdog.BackgroundImage = global::Sales.Properties.Resources.hotdoggray;
            this.btnHotdog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHotdog.Enabled = false;
            this.btnHotdog.Location = new System.Drawing.Point(243, 123);
            this.btnHotdog.Name = "btnHotdog";
            this.btnHotdog.Size = new System.Drawing.Size(118, 114);
            this.btnHotdog.TabIndex = 18;
            this.btnHotdog.UseVisualStyleBackColor = true;
            this.btnHotdog.Click += new System.EventHandler(this.btnHotdog_Click);
            // 
            // btnBavaria
            // 
            this.btnBavaria.BackgroundImage = global::Sales.Properties.Resources.bavariaGray;
            this.btnBavaria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBavaria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBavaria.Enabled = false;
            this.btnBavaria.Location = new System.Drawing.Point(123, 243);
            this.btnBavaria.Name = "btnBavaria";
            this.btnBavaria.Size = new System.Drawing.Size(114, 116);
            this.btnBavaria.TabIndex = 16;
            this.btnBavaria.Tag = "1";
            this.btnBavaria.UseVisualStyleBackColor = true;
            this.btnBavaria.Click += new System.EventHandler(this.btnBavaria_Click);
            // 
            // btnAmstel
            // 
            this.btnAmstel.BackgroundImage = global::Sales.Properties.Resources.amstelGray;
            this.btnAmstel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAmstel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAmstel.Enabled = false;
            this.btnAmstel.Location = new System.Drawing.Point(243, 243);
            this.btnAmstel.Name = "btnAmstel";
            this.btnAmstel.Size = new System.Drawing.Size(119, 116);
            this.btnAmstel.TabIndex = 15;
            this.btnAmstel.Tag = "1";
            this.btnAmstel.UseVisualStyleBackColor = true;
            this.btnAmstel.Click += new System.EventHandler(this.btnAmstel_Click);
            // 
            // btnCoffee
            // 
            this.btnCoffee.BackgroundImage = global::Sales.Properties.Resources.coffeeGray;
            this.btnCoffee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCoffee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCoffee.Enabled = false;
            this.btnCoffee.Location = new System.Drawing.Point(3, 243);
            this.btnCoffee.Name = "btnCoffee";
            this.btnCoffee.Size = new System.Drawing.Size(114, 116);
            this.btnCoffee.TabIndex = 14;
            this.btnCoffee.Tag = "1";
            this.btnCoffee.UseVisualStyleBackColor = true;
            this.btnCoffee.Click += new System.EventHandler(this.btnCoffee_Click);
            // 
            // btnFries
            // 
            this.btnFries.BackgroundImage = global::Sales.Properties.Resources.FriesGray;
            this.btnFries.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFries.Enabled = false;
            this.btnFries.Location = new System.Drawing.Point(123, 3);
            this.btnFries.Name = "btnFries";
            this.btnFries.Size = new System.Drawing.Size(114, 114);
            this.btnFries.TabIndex = 12;
            this.btnFries.UseVisualStyleBackColor = true;
            this.btnFries.Click += new System.EventHandler(this.btnFries_Click);
            // 
            // btnDoner
            // 
            this.btnDoner.BackgroundImage = global::Sales.Properties.Resources.DonerGray;
            this.btnDoner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDoner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDoner.Enabled = false;
            this.btnDoner.Location = new System.Drawing.Point(243, 3);
            this.btnDoner.Name = "btnDoner";
            this.btnDoner.Size = new System.Drawing.Size(119, 114);
            this.btnDoner.TabIndex = 13;
            this.btnDoner.UseVisualStyleBackColor = true;
            this.btnDoner.Click += new System.EventHandler(this.btnDoner_Click);
            // 
            // btnCroquette
            // 
            this.btnCroquette.BackgroundImage = global::Sales.Properties.Resources.CroquetteGray;
            this.btnCroquette.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCroquette.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCroquette.Enabled = false;
            this.btnCroquette.Location = new System.Drawing.Point(3, 3);
            this.btnCroquette.Name = "btnCroquette";
            this.btnCroquette.Size = new System.Drawing.Size(114, 114);
            this.btnCroquette.TabIndex = 8;
            this.btnCroquette.UseVisualStyleBackColor = true;
            this.btnCroquette.Click += new System.EventHandler(this.btnCroquette_Click);
            // 
            // btnHeiniken
            // 
            this.btnHeiniken.BackgroundImage = global::Sales.Properties.Resources.HeinikenGray;
            this.btnHeiniken.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHeiniken.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHeiniken.Enabled = false;
            this.btnHeiniken.Location = new System.Drawing.Point(3, 123);
            this.btnHeiniken.Name = "btnHeiniken";
            this.btnHeiniken.Size = new System.Drawing.Size(114, 114);
            this.btnHeiniken.TabIndex = 11;
            this.btnHeiniken.UseVisualStyleBackColor = true;
            this.btnHeiniken.Click += new System.EventHandler(this.btnHeiniken_Click);
            // 
            // btnCola
            // 
            this.btnCola.BackgroundImage = global::Sales.Properties.Resources.ColaGray;
            this.btnCola.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCola.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCola.Enabled = false;
            this.btnCola.Location = new System.Drawing.Point(123, 123);
            this.btnCola.Name = "btnCola";
            this.btnCola.Size = new System.Drawing.Size(114, 114);
            this.btnCola.TabIndex = 7;
            this.btnCola.Tag = "1";
            this.btnCola.UseVisualStyleBackColor = true;
            this.btnCola.Click += new System.EventHandler(this.btnCola_Click);
            // 
            // pnlTopBorder
            // 
            this.pnlTopBorder.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.pnlTopBorder.Controls.Add(this.label3);
            this.pnlTopBorder.Controls.Add(this.cbShop);
            this.pnlTopBorder.Location = new System.Drawing.Point(0, 1);
            this.pnlTopBorder.Name = "pnlTopBorder";
            this.pnlTopBorder.Size = new System.Drawing.Size(1475, 56);
            this.pnlTopBorder.TabIndex = 8;
            // 
            // lbSwipe
            // 
            this.lbSwipe.AutoSize = true;
            this.lbSwipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbSwipe.ForeColor = System.Drawing.Color.Honeydew;
            this.lbSwipe.Location = new System.Drawing.Point(18, 12);
            this.lbSwipe.Name = "lbSwipe";
            this.lbSwipe.Size = new System.Drawing.Size(307, 36);
            this.lbSwipe.TabIndex = 8;
            this.lbSwipe.Text = "Swipe tag to checkout";
            this.lbSwipe.Visible = false;
            // 
            // pnlSwipe
            // 
            this.pnlSwipe.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.pnlSwipe.Controls.Add(this.lbSwipe);
            this.pnlSwipe.Location = new System.Drawing.Point(114, 394);
            this.pnlSwipe.Name = "pnlSwipe";
            this.pnlSwipe.Size = new System.Drawing.Size(347, 58);
            this.pnlSwipe.TabIndex = 8;
            this.pnlSwipe.Visible = false;
            // 
            // pnMenuBorder
            // 
            this.pnMenuBorder.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnMenuBorder.Controls.Add(this.tlpnMenu);
            this.pnMenuBorder.Location = new System.Drawing.Point(23, 27);
            this.pnMenuBorder.Name = "pnMenuBorder";
            this.pnMenuBorder.Size = new System.Drawing.Size(379, 379);
            this.pnMenuBorder.TabIndex = 18;
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1352, 981);
            this.Controls.Add(this.pnlTopBorder);
            this.Controls.Add(this.groupBox_Cart);
            this.Controls.Add(this.groupBox_Add);
            this.Name = "Sales";
            this.Text = "Sales";
            this.groupBox_Cart.ResumeLayout(false);
            this.groupBox_Cart.PerformLayout();
            this.groupBox_Add.ResumeLayout(false);
            this.groupBox_Add.PerformLayout();
            this.tlpnMenu.ResumeLayout(false);
            this.pnlTopBorder.ResumeLayout(false);
            this.pnlTopBorder.PerformLayout();
            this.pnlSwipe.ResumeLayout(false);
            this.pnlSwipe.PerformLayout();
            this.pnMenuBorder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Cart;
        private System.Windows.Forms.ListView listView_Cart;
        private System.Windows.Forms.ColumnHeader Product_cart;
        private System.Windows.Forms.ColumnHeader Price_Cart;
        private System.Windows.Forms.ColumnHeader Amount;
        private System.Windows.Forms.ColumnHeader Subtotal;
        private System.Windows.Forms.Button button_Remove;
        private System.Windows.Forms.Label label_Total;
        private System.Windows.Forms.GroupBox groupBox_Add;
        private System.Windows.Forms.ListView listView_Add;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Product;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.Label label_1;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.ColumnHeader Stock;
        private System.Windows.Forms.ComboBox cbShop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Button btnCola;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnDoner;
        private System.Windows.Forms.Button btnFries;
        private System.Windows.Forms.Button btnHeiniken;
        private System.Windows.Forms.Button btnCroquette;
        private System.Windows.Forms.TableLayoutPanel tlpnMenu;
        private System.Windows.Forms.Button btnHotdog;
        private System.Windows.Forms.Button btnBavaria;
        private System.Windows.Forms.Button btnAmstel;
        private System.Windows.Forms.Button btnCoffee;
        private System.Windows.Forms.Panel pnlTopBorder;
        private System.Windows.Forms.Panel pnlSwipe;
        private System.Windows.Forms.Label lbSwipe;
        private System.Windows.Forms.Panel pnMenuBorder;
    }
}

